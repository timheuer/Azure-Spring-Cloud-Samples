using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Microsoft.Azure.SpringCloud.Sample.WeatherApp.Data
{
    public class WeatherForecastService : ISolarSystemService
    {
        private const string SERVICE_URI = "https://solar-system-weather/weatherforecast";
        private HttpClient _client;

        public WeatherForecastService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<KeyValuePair<string, string>>> GetPlanetWeather()
        {
            return await _client.GetFromJsonAsync<IEnumerable<KeyValuePair<string, string>>>(SERVICE_URI);
        }
    }

    public interface ISolarSystemService
    {
        Task<IEnumerable<KeyValuePair<string, string>>> GetPlanetWeather();
    }
}
