using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumWeather
{
    class Meteorology
    {
        enum Days {Sun, Mon, Tues, Wed, Thurs, Fri, Sat};
        enum Weather {Sunny, PartlySunny, PartlyCloudy, Cloudy, Rainy, Stormy};
        Random rand = new Random();


        public void Forecast()
        {
            string[] weekahead = Enum.GetNames(typeof(Days));
            string[] weather = Enum.GetNames(typeof(Weather));
            foreach (var day in weekahead)
            {
                int random = rand.Next(0, 6);
                Console.WriteLine("{0}'s weather will be {1}.", day, weather[random]);
            }
            Console.ReadKey(true);
        }
    }
}
