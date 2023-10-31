namespace Mediator
{
    class Logger
    {
        private LogCreator creator;
        private LogWriter writer;

        public Logger(string fileName)
        {
            creator = new LogCreator();
            writer = new LogWriter(fileName);
        }

        public void AddMessange(string messange)
        {
            var logMessange = creator.CreateLog(messange);
            writer.WriteMessange(logMessange);
        }
    }
}
