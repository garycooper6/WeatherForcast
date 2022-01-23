using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForcast.Core.Interfaces;
using WeatherForcast.Core.Models.WeatherAPI;

namespace WeatherForecast.Tests
{
    public class FakeWeatherAPI : IWeatherAPI
    {


        WeatherModel testData = new WeatherModel()
        {
            Location = new Location()
            {
                Name = "London",
                Region = "City of London, Greater London",
                Country = "United Kingdom",
                Lat = 51.52f,
                Lon = -0.11f,
                Tz_id = "Europe/London",
                Localtime = "2022-01-23 14:41"
            },
            Forecast = new Forecast()
            {
                Forecastday = new List<Forecastday>()
                {
                    new Forecastday()
                    {
                     Date = "2022-01-23",
                    Day = null,
                    Hour = new List<Hour>()
                            {
                        new Hour()
                        {


                        Time = "2022-01-23 16:00",
                        Condition = new Condition()
                        {
                            Text = "Cloudy"
                        }
                        }
                    }
                    }
                }
            }
        };



        public async Task<WeatherModel> GetWeather(string city)
        {
            return testData;
        }

        public async Task<WeatherModel> GetWeather(string city, string days)
        {
            return testData;
        }
    }
}
