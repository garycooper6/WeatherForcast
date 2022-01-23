using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForcast.Core.Models.WeatherAPI;

namespace WeatherForcast.Core.DTO
{
    public class WeatherForecastDisplay
    {
        public Location Location { get; set; }
        public IEnumerable<Hour> HourlyForcast { get; set; }
    }
}
