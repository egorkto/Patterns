using System;

namespace State
{
    public class RainWeather : IWeatherState
    {
        public void Froze(Weather weather)
        {
            weather.SetState(new SnowWeather());
            Console.WriteLine("Похалодало, пошел снег");
        }

        public void Heat(Weather weather)
        {
            weather.SetState(new HotWeather());
            Console.WriteLine("Дождь закончился, стало теплее");
        }
    }
}
