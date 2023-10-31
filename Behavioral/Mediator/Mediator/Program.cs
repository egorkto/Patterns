using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger("Test");
            logger.AddMessange("Hello");
        }
    }
}
