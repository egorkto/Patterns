using System.IO;
using System.Text;

namespace Mediator
{
    class LogWriter
    {
        private string fileName;

        public LogWriter(string fileName)
        {
            this.fileName = $"{fileName}.txt";
        }

        public void WriteMessange(LogMessange messange)
        {
            using(var file = new StreamWriter(fileName, true, Encoding.UTF8))
            {
                file.WriteLine(messange.Messange);
                file.WriteLine(messange.Date);
            }
        }
    }
}
