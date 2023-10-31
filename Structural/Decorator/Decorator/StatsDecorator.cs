namespace Decorator
{
    public abstract class StatsDecorator : IStatsProvider
    {
        protected IStatsProvider wrappedEntity;

        public StatsDecorator(IStatsProvider WrappedEntity)
        {
            wrappedEntity = WrappedEntity;
        }

        public abstract PlayerStats GetStats();
    }
}
