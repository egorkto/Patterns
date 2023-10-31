using System.IO;
using System.Text;

namespace Strategy
{
    class FileWriter
    {
        private string fileName;

        public FileWriter(string FileName)
        {
            fileName = $"{FileName}.txt";
        }

        public void Write(IWriteStrategy strategy, string messange)
        {
            strategy.Write(messange, fileName);
        }

        public void ClearFile()
        {
            using(var file = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                file.Close();
            }
        }
    }
}
