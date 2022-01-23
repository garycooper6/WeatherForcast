using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WeatherForcast.Core.Interfaces;

namespace WeatherForcast.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherAPI _weatherAPI;
        private readonly IFilterWeatherDisplay _filterWeather;

        public HomeController(IWeatherAPI weatherAPI, IFilterWeatherDisplay filterWeather)
        {
            _weatherAPI = weatherAPI;
            _filterWeather = filterWeather;
        }

        public ActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> Index(string city)
        {
            var weatherModel = await _weatherAPI.GetWeather(city, "1");

            return View(_filterWeather.FilterWeatherModel(weatherModel));
        }
    }
}
