using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForcast.Core.Models.WeatherAPI
{
    public class Forecastday
    {
        public string Date { get; set; }
        public Day Day { get; set; }
        public IEnumerable<Hour> Hour { get; set; }
    }
}
