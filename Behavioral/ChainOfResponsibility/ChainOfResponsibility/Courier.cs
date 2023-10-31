using System;

namespace ChainOfResponsibility
{
    public class Courier : GetThingWay
    {
        public override void Handle(DeliveryController controller)
        {
            if(controller.CanDelive(this))
            {
                Console.WriteLine("Доставка курьером");
            }

            else if(Successor != null)
            {
                Successor.Handle(controller);
            }
        }
    }
}
