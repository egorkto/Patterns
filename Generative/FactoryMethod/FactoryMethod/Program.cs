using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruitFarmer = new FruitFarmer();
            var vegetableFarmer = new VegetableFarmer();
            Console.WriteLine(fruitFarmer.Grow("яблоко").Name);
            Console.WriteLine(vegetableFarmer.Grow("огурец").Name);
        }
    }
}
