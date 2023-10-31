namespace Facade
{
    public class Wheel
    {
        private bool spining;

        public void Spin()
        {
            spining = true;
        }

        public void Stop()
        {
            spining = false;
        }
    }
}
