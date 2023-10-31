using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IServer proxy = new ProxyServer();
            var client = new Client("Дима", "12345");
            var client2 = new Client("Вова", "14563");
            var client3 = new Client("Дима", "17944");

            proxy.AddClient(client);
            proxy.AddClient(client2);
            proxy.AddClient(client3);

            proxy.DisplayClients();
        }
    }
}
