using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var weather = new Weather(new RainWeather());
            weather.Heat();
            weather.Heat();
            weather.Froze();
            weather.Froze();
        }
    }
}
