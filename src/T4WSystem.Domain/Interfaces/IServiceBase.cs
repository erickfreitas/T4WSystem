using System.Net.Http;

namespace T4WSystem.Domain.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        HttpClient CreateHttpClient(string urlComplement);
    }
}
