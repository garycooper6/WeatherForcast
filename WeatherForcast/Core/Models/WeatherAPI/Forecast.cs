using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForcast.Core.Models.WeatherAPI
{
    public class Forecast
    {
        public IEnumerable<Forecastday> Forecastday { get; set; }
    }
}
