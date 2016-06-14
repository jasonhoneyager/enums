using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            Meteorology meteorology = new Meteorology();
            meteorology.Forecast();
        }
    }
}
