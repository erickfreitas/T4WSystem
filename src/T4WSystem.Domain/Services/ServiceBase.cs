using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using T4WSystem.Domain.Entities;
using T4WSystem.Domain.Interfaces;

namespace T4WSystem.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        protected readonly string _url = ConfigurationManager.AppSettings["ApiUrl"];
        protected readonly string _user = ConfigurationManager.AppSettings["ApiUser"];
        protected readonly string _password = ConfigurationManager.AppSettings["ApiPassword"];

        public HttpClient CreateHttpClient(string urlComplement)
        {
            var client = new HttpClient { BaseAddress = new Uri(_url + urlComplement) };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        public Credential CreateCredential()
        {
            return new Credential
            {
                Username = _user,
                Password = _password
            };
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
