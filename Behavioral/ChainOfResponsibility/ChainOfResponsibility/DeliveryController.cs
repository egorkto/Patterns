namespace ChainOfResponsibility
{
    public class DeliveryController
    {
        private bool mailDelivery;
        private bool courierDelivery;
        private bool onMarketDelivery;

        public DeliveryController(bool _courierDelivery, bool _mailDelivery, bool _onPlaceDelivery)
        {
            mailDelivery = _mailDelivery;
            courierDelivery = _courierDelivery;
            onMarketDelivery = _onPlaceDelivery;
        }

        public bool CanDelive(Mail mailDelive)
        {
            return mailDelivery;
        }

        public bool CanDelive(Courier courierDelive)
        {
            return courierDelivery;
        }

        public bool CanDelive(OnMaret onMarketDelive)
        {
            return onMarketDelivery;
        }
    }
}
