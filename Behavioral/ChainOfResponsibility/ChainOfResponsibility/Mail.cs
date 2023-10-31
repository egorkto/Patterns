using System;

namespace ChainOfResponsibility
{
    public class Mail : GetThingWay
    {
        public override void Handle(DeliveryController controller)
        {
            if (controller.CanDelive(this))
            {
                Console.WriteLine("Доставка почтой");
            }

            else if (Successor != null)
            {
                Successor.Handle(controller);
            }
        }
    }
}
