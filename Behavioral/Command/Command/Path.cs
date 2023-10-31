namespace Command
{
    class Path
    {
        public readonly string StartPoint;
        public readonly string FinishPoint;

        public Path(string startPoint, string finishPoint)
        {
            StartPoint = startPoint;
            FinishPoint = finishPoint;
        }
    }
}
