using System;
using System.Collections.Generic;

namespace Facade
{
    public class Suspension
    {
        private List<Wheel> wheels;

        public Suspension(int _wheelsCount)
        {
            wheels = new List<Wheel>();

            for(var i = 0; i < _wheelsCount; i++)
            {
                wheels.Add(new Wheel());
            }
        }

        public void SpinWheels(SpinDirection direction)
        {
            switch(direction) 
            {
                case SpinDirection.Clockwise:
                {
                    Console.WriteLine("Колеса крутятся по часовой");
                    break;
                }

                case SpinDirection.Counterclockwise:
                {
                    Console.WriteLine("Колеса крутятся против часовой");
                    break;
                }
            }

            foreach(var wheel in wheels)
            {
                wheel.Spin();
            }
        }

        public void StopWheels()
        {
            Console.WriteLine("Колеса не крутятся");

            foreach (var wheel in wheels)
            {
                wheel.Stop();
            }
        }
    }

    public enum SpinDirection
    {
        Clockwise,
        Counterclockwise
    }
}
