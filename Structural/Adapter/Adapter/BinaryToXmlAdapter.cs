using System;

namespace Adapter
{
    class BinaryToXmlAdapter : IDataSaver
    {
        XmlDataSaver saver = new XmlDataSaver();

        public void Save(string fileName, Data data)
        {
            var newFileName = ConvertFileName(fileName);
            saver.Save(newFileName, data);
        }

        private string ConvertFileName(string fileName)
        {
            var nameFile = fileName.Split(new char[] { '.' })[0];

            return nameFile + ".xml";
        }
    }
}
