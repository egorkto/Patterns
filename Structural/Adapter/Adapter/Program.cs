using System;
using System.IO;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataSaver saver;
            var fileName = "data.bin";
            var data = new Data("Egor", "Hello");

            saver = new BinaryDataSaver();

            saver.Save(fileName, data);

            saver = new BinaryToXmlAdapter();

            saver.Save(fileName, data);
        }
    }
}
