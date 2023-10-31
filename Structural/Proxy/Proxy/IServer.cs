namespace Proxy
{
    public interface IServer
    {
        public void AddClient(Client client);
        public void DisplayClients();
    }
}
