namespace Proxy
{
    public class Client
    {
        public readonly string Login;
        public readonly string Password;

        public Client(string _login, string _password)
        {
            Login = _login;
            Password = _password;
        }

        public static bool operator ==(Client client1, Client client2)
        {
            if(client1.Login == client2.Login)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Client client1, Client client2)
        {
            if (client1.Login == client2.Login)
            {
                return false;
            }

            return true;
        }
    }
}
