using System;

namespace AbstractFactory
{
    public class CarFactory : VehicleFactory
    {
        public override Vehicle Create()
        {
            Console.WriteLine("Произведена машина");
            return new Car();
        }
    }
}
