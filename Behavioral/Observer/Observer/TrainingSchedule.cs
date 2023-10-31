using System;
using System.Timers;

namespace Observer
{
    class TrainingSchedule
    {
        public event EventHandler<TrainingScheduleEventArgs> OnTraining;

        private const int day = 2000;

        private TrainingData[] trainingDatas;
        private int currentDay = 0;

        public TrainingSchedule(TrainingData[] Datas)
        {
            trainingDatas = Datas;
            SetTimer();
        }

        private void SetTimer()
        {
            var timer = new Timer(day);
            timer.Elapsed += OnTimesUp;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTimesUp(Object source, ElapsedEventArgs args)
        {
            OnTraining?.Invoke(this, new TrainingScheduleEventArgs(trainingDatas[currentDay]));
            currentDay = SetNextDay();
        }

        private int SetNextDay()
        {
            return (currentDay + 1) % trainingDatas.Length;
        }
    }
}
