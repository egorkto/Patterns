using System;

namespace State
{
    public class SnowWeather : IWeatherState
    {
        public void Froze(Weather weather)
        {
            Console.WriteLine("Холоднее только в космосе");
        }

        public void Heat(Weather weather)
        {
            weather.SetState(new RainWeather());
            Console.WriteLine("Начинается дождь");
        }
    }
}
