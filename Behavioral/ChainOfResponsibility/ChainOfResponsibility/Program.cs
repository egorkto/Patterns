namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new DeliveryController(false, false, true);
            var onMarket = new OnMaret();
            var mail = new Mail();
            var courier = new Courier();

            courier.SetSuccessor(mail);
            mail.SetSuccessor(onMarket);

            courier.Handle(controller);
        }
    }
}
