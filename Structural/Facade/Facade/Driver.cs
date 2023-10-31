namespace Facade
{
    public class Driver
    {
        private CarFacade facade;

        public Driver(CarFacade _facade)
        {
            facade = _facade;
        }

        public void PushLeftPedal()
        {
            facade.DriveForward();
        }

        public void PushMiddlePedal()
        {
            facade.StopDrive();
        }

        public void PushRightPedal()
        {
            facade.DriveBack();
        }
    }
}
