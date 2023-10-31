namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var carFactory = new CarFactory();
            var truckFactory = new TruckFactory();

            carFactory.Create();
            truckFactory.Create();
        }
    }
}
