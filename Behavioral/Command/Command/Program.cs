using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = new Path("Ленина", "Пушкина");
            var manager = new TaxiManager();
            var cabby = new Cabby();
            manager.SetTaxiCommand(cabby);
            manager.CreateCall(path);
            manager.RefuseCall(path);
        }
    }
}