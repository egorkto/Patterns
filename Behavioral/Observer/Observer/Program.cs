using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingData[] data = new TrainingData[]
            {
                new TrainingData(10, 15, 3, 1),
                new TrainingData(5, 7, 20, 3),
                new TrainingData(1, 1, 10, 25),
            };

            var schedule = new TrainingSchedule(data);
            var sporsman = new Sportsman(schedule);
            Console.ReadLine();
        }
    }
}
