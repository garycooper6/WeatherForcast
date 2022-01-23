using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WeatherForcast.Core.Interfaces;
using WeatherForcast.Core.Models.WeatherAPI;

namespace WeatherForcast.Infrastructure.Services
{
    public class WeatherAPI : IWeatherAPI
    {
        private readonly IHttpClientFactory _httpClient;

        public WeatherAPI(IHttpClientFactory httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<WeatherModel> GetWeather(string city)
        {
            var weatherModel = new WeatherModel();

            try
            {
                var client = _httpClient.CreateClient("weather");

                weatherModel = await client.GetFromJsonAsync<WeatherModel>($"current.json?q={city}");
            }
            catch (Exception ex)
            {
                //TODO
            }

            return weatherModel;
        }

        public async Task<WeatherModel> GetWeather(string city, string days)
        {
            var weatherModel = new WeatherModel();

            try
            {
                var client = _httpClient.CreateClient("weather");

                weatherModel = await client.GetFromJsonAsync<WeatherModel>($"forecast.json?q={city}&days={days}");


            }
            catch (Exception ex)
            {
                //TODO
            }

            return weatherModel;
        }
    }
}