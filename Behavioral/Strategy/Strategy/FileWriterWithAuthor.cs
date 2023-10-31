using System.IO;
using System.Text;

namespace Strategy
{
    class FileWriterWithAuthor : IWriteStrategy
    {
        private Author author;

        public FileWriterWithAuthor(Author Author)
        {
            author = Author;
        }

        public void Write(string messange, string fileName)
        {
            using (var file = new StreamWriter(fileName, true, Encoding.UTF8))
            {
                file.WriteLine(messange);
                file.WriteLine(author.ToString());
                file.WriteLine("-------------------");
            }
        }
    }
}
