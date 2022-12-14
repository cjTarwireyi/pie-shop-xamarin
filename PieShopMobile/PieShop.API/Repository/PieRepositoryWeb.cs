using Newtonsoft.Json;
using PieShopMobile.API.Model;
using System.Net.Http.Headers;

namespace PieShopMobile.API.Repository
{
    public class PieRepositoryWeb
    {
        public async Task<List<Pie>> GetAllPies()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = await httpClient.GetAsync("http://192.168.1.35:5000/api/pies");

            if (!responseMessage.IsSuccessStatusCode) return null;

            var jsonResult = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            var pies = JsonConvert.DeserializeObject<IEnumerable<Pie>>(jsonResult);
            return pies.ToList();

        }

        public async Task<Pie> GetPieById(int id)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = await httpClient.GetAsync("http://192.168.1.35:5000/api/pies/" + id);

            if (!responseMessage.IsSuccessStatusCode) return null;

            var jsonResult = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            var pies = JsonConvert.DeserializeObject<Pie>(jsonResult);
            return pies;
        }
    }
}
