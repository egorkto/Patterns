using System;

namespace Adapter
{
    [Serializable] public class Data
    {
        public readonly DateTime Date;
        public readonly string Author;
        public readonly string Messange;

        public Data() { }

        public Data(string _author, string _messange)
        {
            Date = DateTime.Now;
            Author = _author;
            Messange = _messange;
        }

        public override string ToString()
        {
            return $"{Date.ToString()}, {Author}, {Messange}";
        }
    }
}
