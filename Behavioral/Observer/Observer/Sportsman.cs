using System;

namespace Observer
{
    class Sportsman
    {
        private TrainingData data;

        public Sportsman(TrainingSchedule schedule)
        {
            schedule.OnTraining += Training;
        }

        private void Training(object sender, TrainingScheduleEventArgs args)
        {
            data += args.Data;
            Console.WriteLine(data);
        }
    }
}
