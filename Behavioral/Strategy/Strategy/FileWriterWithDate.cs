using System;
using System.IO;
using System.Text;

namespace Strategy
{
    class FileWriterWithDate : IWriteStrategy
    {
        private DateTime date;

        public void Write(string messange, string fileName)
        {
            date = DateTime.Now;
            using (var file = new StreamWriter(fileName, true, Encoding.UTF8))
            {
                file.WriteLine(messange);
                file.WriteLine(date.ToString());
                file.WriteLine("-------------------");
            }
        }
    }
}
