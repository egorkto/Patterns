using System;

namespace ChainOfResponsibility
{
    public class OnMaret : GetThingWay
    {
        public override void Handle(DeliveryController controller)
        {
            if (controller.CanDelive(this))
            {
                Console.WriteLine("Получение заказа в магазине");
            }

            else if (Successor != null)
            {
                Successor.Handle(controller);
            }
        }
    }
}
