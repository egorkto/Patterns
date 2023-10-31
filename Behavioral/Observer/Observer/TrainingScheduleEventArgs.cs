using System;

namespace Observer
{
    class TrainingScheduleEventArgs : EventArgs
    {
        public TrainingData Data { get; }

        public TrainingScheduleEventArgs(TrainingData trainingData)
        {
            Data = trainingData;
        }
    }
}
