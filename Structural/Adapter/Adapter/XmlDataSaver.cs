using System.IO;
using System.Xml.Serialization;

namespace Adapter
{
    class XmlDataSaver
    {
        public void Save(string fileName, Data data)
        {
            var formatter = new XmlSerializer(typeof(Data));

            using (var file = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(file, data);
            }
        }
    }
}
