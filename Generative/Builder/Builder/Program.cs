using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IPCFabric PCFabric;
            PCFabric = new OfficePCFabric();
            var pc1 = PCFabric.Create();

            PCFabric = new GamingPCFabric();
            var pc2 = PCFabric.Create();

            Console.WriteLine(pc1);
            Console.WriteLine(pc2);
        }
    }
}
