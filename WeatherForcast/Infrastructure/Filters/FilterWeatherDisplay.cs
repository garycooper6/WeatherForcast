using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForcast.Core.DTO;
using WeatherForcast.Core.Interfaces;
using WeatherForcast.Core.Models.WeatherAPI;

namespace WeatherForcast.Infrastructure.Filters
{
    public class FilterWeatherDisplay : IFilterWeatherDisplay
    {
        public WeatherForecastDisplay FilterWeatherModel(WeatherModel weatherModel)
        {
            var WeatherForecastDisplay = new WeatherForecastDisplay();

            if (weatherModel.Location != null && weatherModel.Forecast != null)
            {

                var hourlyForcast = weatherModel.Forecast.Forecastday
                    .FirstOrDefault()
                    .Hour
                    .Where(h => Convert.ToDateTime(h.Time) >= DateTime.Now && Convert.ToDateTime(h.Time) <= DateTime.Now.AddHours(3));

                WeatherForecastDisplay.Location = weatherModel.Location;
                WeatherForecastDisplay.HourlyForcast = hourlyForcast;
            }
            return WeatherForecastDisplay;
        }
    }
}
