namespace Proxy
{
    class ProxyServer : IServer
    {
        Server server;

        public ProxyServer()
        {
            server = new Server();
        }

        public void AddClient(Client client)
        {
            if(server.ClientCanRegistered(client))
            {
                server.AddClient(client);
            }
        }

        public void DisplayClients()
        {
            server.DisplayClients();
        }
    }
}
