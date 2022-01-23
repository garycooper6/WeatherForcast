using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForcast.Core.Models.WeatherAPI;

namespace WeatherForcast.Core.Interfaces
{
    public interface IWeatherAPI
    {
        Task<WeatherModel> GetWeather(string city);
        Task<WeatherModel> GetWeather(string city, string days);
    }
}
