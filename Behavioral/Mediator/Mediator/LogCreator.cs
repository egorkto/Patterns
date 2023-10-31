using System;

namespace Mediator
{
    class LogCreator
    {
        public LogMessange CreateLog(string messange)
        {
            var date = (DateTime.Now).ToString();
            return new LogMessange(messange, date);
        }
    }
}
