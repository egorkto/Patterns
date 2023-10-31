using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            var fuelSystem = new FuelSystem();
            var suspension = new Suspension(4);
            var facade = new CarFacade(engine, suspension, fuelSystem);
            var driver = new Driver(facade);

            driver.PushLeftPedal();
            driver.PushMiddlePedal();
            driver.PushRightPedal();
        }
    }
}
