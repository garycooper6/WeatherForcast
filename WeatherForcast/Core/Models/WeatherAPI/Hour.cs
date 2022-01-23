using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForcast.Core.Models.WeatherAPI
{
    public class Hour
    {
        public string Time { get; set; }
        public Condition Condition { get; set; }
    }
}
