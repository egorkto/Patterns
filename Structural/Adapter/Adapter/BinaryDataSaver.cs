using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Adapter
{
    public class BinaryDataSaver : IDataSaver
    {
        public void Save(string fileName, Data data)
        {
            var formatter = new BinaryFormatter();

            using(var file = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(file, data);
            }
        }
    }
}
