using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForcast.Core.Models.WeatherAPI
{
    public class WeatherModel
    {
        public Location Location { get; set; }
        public Forecast Forecast { get; set; }
    }
}
