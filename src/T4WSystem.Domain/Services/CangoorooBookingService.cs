using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using T4WSystem.Domain.Entities;
using T4WSystem.Domain.Interfaces;

namespace T4WSystem.Domain.Services
{
    public class CangoorooBookingService : ServiceBase<Hotel>, ICangoorooBookingService
    {
        public async Task<IEnumerable<Hotel>> GetHotels(Criteria criteria)
        {
            //method to get hotels according to filter
            var request = new Request { Credential = CreateCredential(), Criteria = criteria };
            var jsonRequest = new JavaScriptSerializer().Serialize(request);
            var client = CreateHttpClient("/Search");
            var response = await client.PostAsync($"{_url}/Search", new StringContent(jsonRequest, Encoding.UTF8, "application/json"));
            var responseStringJson = await response.Content.ReadAsStringAsync();
            var deserialized = new JavaScriptSerializer().Deserialize<Response>(responseStringJson);
            return deserialized.Hotels;
        }
    }
}
