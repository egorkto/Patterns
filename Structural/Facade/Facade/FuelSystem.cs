namespace Facade
{
    public class FuelSystem
    {
        public bool haveFuel { get; private set; }

        public void GiveFuel(Engine engine)
        {
            engine.GetFuel();
        }
    }
}
