using System;

namespace Decorator
{
    class SpecializationStats : StatsDecorator
    {
        private Specialization specialization { get; }

        public SpecializationStats(IStatsProvider WrappedEntity, Specialization Specialization) : base(WrappedEntity)
        {
            specialization = Specialization;
        }

        public override PlayerStats GetStats()
        {
            return wrappedEntity.GetStats() + GetSpecializationStats(specialization);
        }

        private PlayerStats GetSpecializationStats(Specialization specialization)
        {
            switch (specialization)
            {
                case Specialization.Thief:
                    return new PlayerStats()
                    {
                        Strenght = 7,
                        Intelligence = 7,
                        Stamina = 10
                    };

                case Specialization.Warrior:
                    return new PlayerStats()
                    {
                        Strenght = 10,
                        Intelligence = 5,
                        Stamina = 7
                    };

                case Specialization.Wizard:
                    return new PlayerStats()
                    {
                        Strenght = 5,
                        Intelligence = 10,
                        Stamina = 5
                    };

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
