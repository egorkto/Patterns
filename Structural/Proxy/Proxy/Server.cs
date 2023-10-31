using System;
using System.Collections.Generic;

namespace Proxy
{
    class Server : IServer
    {
        private List<Client> clients;

        public Server()
        {
            clients = new List<Client>();
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        public void DisplayClients()
        {
            foreach(var client in clients)
            {
                Console.WriteLine(client.Login);
            }
        }

        public bool ClientCanRegistered(Client client)
        {
            if(LoginIsValible(client.Login) && HaveNotSameClient(client))
            {
                return true;
            }

            return false;
        }

        private bool LoginIsValible(string login)
        {
            return true;
        }

        private bool HaveNotSameClient(Client client)
        {
            foreach(var currentClient in clients)
            {
                if(client == currentClient)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
