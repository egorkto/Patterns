namespace Facade
{
    public class CarFacade
    {
        private Engine engine;
        private Suspension suspension;
        private FuelSystem fuelSystem;

        public CarFacade(Engine _engine, Suspension _suspension, FuelSystem _fuelSystem)
        {
            engine = _engine;
            suspension = _suspension;
            fuelSystem = _fuelSystem;
        }

        public void DriveForward()
        {
            StartEngine();
            suspension.SpinWheels(SpinDirection.Counterclockwise);
        }

        public void DriveBack()
        {
            StartEngine();
            suspension.SpinWheels(SpinDirection.Clockwise);
        }

        public void StopDrive()
        {
            engine.Stop();
            suspension.StopWheels();
        }

        private void StartEngine()
        {
            fuelSystem.GiveFuel(engine);
            engine.TryStart();
        }
    }
}
