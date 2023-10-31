namespace Decorator
{
    public class Player
    {
        private IStatsProvider provider;

        public Player(RaceType race, Specialization specialization)
        {
            provider = new SpecializationStats(new RaceStats(race), specialization);
        }

        public override string ToString()
        {
            return $"Strenght: {provider.GetStats().Strenght}, " +
                $"Intelligence: {provider.GetStats().Intelligence}, " +
                $"Stamina: {provider.GetStats().Stamina}";
        }
    }
}
