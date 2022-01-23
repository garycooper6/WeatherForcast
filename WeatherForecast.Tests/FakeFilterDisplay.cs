using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForcast.Core.DTO;
using WeatherForcast.Core.Interfaces;
using WeatherForcast.Core.Models.WeatherAPI;

namespace WeatherForecast.Tests
{
    public class FakeFilterDisplay : IFilterWeatherDisplay
    {
        public WeatherForecastDisplay FilterWeatherModel(WeatherModel weatherModel)
        {
            var returnModel = new WeatherForecastDisplay();

            if (weatherModel.Location != null && weatherModel.Forecast != null)
            {

                var hourlyForcast = weatherModel.Forecast.Forecastday.FirstOrDefault().Hour;

                returnModel.Location = weatherModel.Location;
                returnModel.HourlyForcast = hourlyForcast;
            }
            return returnModel;
        }
    }
}
