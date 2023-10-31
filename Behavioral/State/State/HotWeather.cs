using System;

namespace State
{
    public class HotWeather : IWeatherState
    {
        public void Froze(Weather weather)
        {
            weather.SetState(new RainWeather());
            Console.WriteLine("Начинается дождь");
        }

        public void Heat(Weather weather)
        {
            Console.WriteLine("Жарче некуда");
        }
    }
}
