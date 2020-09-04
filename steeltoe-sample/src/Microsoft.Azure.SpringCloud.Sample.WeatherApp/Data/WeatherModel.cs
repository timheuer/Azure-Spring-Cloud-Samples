using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Azure.SpringCloud.Sample.WeatherApp.Data
{
    public class WeatherModel : PageModel
    {
        public IEnumerable<KeyValuePair<string, string>> CurrentWeather;
        private readonly ISolarSystemService _solarSystemService;

        public WeatherModel(ISolarSystemService solarSystemService)
        {
            _solarSystemService = solarSystemService;
        }

        public async Task OnGet()
        {
            CurrentWeather = await _solarSystemService.GetPlanetWeather();
        }
    }
}
