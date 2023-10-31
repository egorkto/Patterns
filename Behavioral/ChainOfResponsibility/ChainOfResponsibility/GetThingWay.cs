namespace ChainOfResponsibility
{
    public abstract class GetThingWay
    {
        public GetThingWay Successor { get; private set; }

        public void SetSuccessor(GetThingWay successor)
        {
            Successor = successor;
        }

        public abstract void Handle(DeliveryController controller);
    }
}
