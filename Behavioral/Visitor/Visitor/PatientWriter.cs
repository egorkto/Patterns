using System.IO;
using System.Text;

namespace Visitor
{
    class PatientWriter
    {
        private string fileName;

        public PatientWriter(string _fileName)
        {
            fileName = _fileName;
        }

        public void Write(string patientsProblem)
        {
            using(var writer = new StreamWriter(fileName, true, Encoding.UTF8))
            {
                writer.WriteLine(patientsProblem);
            }
        }
    }
}
