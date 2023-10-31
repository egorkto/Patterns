using System;

namespace Facade
{
    public class Engine
    {
        private bool haveFuel;
        private bool run;

        public void GetFuel()
        {
            haveFuel = true;
        }

        public void TryStart()
        {
            if(haveFuel)
            {
                Console.WriteLine("Двигатель запущен");
                run = true;
            }

            else
            {
                Console.WriteLine("Нет топлива");
            }
        }

        public void Stop()
        {
            Console.WriteLine("Двигатель остановлен");
            run = false;
        }
    }
}
