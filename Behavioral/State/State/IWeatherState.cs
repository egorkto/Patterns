namespace State
{
    public interface IWeatherState
    {
        public void Heat(Weather weather);
        public void Froze(Weather weather);
    }
}