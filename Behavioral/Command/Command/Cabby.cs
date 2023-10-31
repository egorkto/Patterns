using System;
using System.Collections.Generic;

namespace Command
{
    class Cabby : ITaxiCommand
    {
        private List<Path> paths;

        public Cabby()
        {
            paths = new List<Path>();
        }

        public void Accept(Path path)
        {
            paths.Add(path);
            Console.WriteLine("Создан заказ: " + path.StartPoint + " - " + path.FinishPoint);
        }

        public void Cancel(Path path)
        {
            paths.Remove(path);
            Console.WriteLine("Отменен: " + path.StartPoint + " - " + path.FinishPoint);
        }
    }
}
