using System;

namespace AbstractFactory
{
    public class TruckFactory : VehicleFactory
    {
        public override Vehicle Create()
        {
            Console.WriteLine("Произведен грузовик");
            return new Truck();
        }
    }
}
