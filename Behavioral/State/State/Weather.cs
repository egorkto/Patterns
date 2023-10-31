namespace State
{
    public class Weather
    {
        private IWeatherState state;

        public Weather(IWeatherState _state)
        {
            state = _state;
        }

        public void SetState(IWeatherState _state)
        {
            state = _state;
        }

        public void Heat()
        {
            state.Heat(this);
        }

        public void Froze()
        {
            state.Froze(this);
        }
    }
}
