using System;

namespace Decorator
{
    public class RaceStats : IStatsProvider
    {
        private RaceType race { get; }

        public RaceStats(RaceType Race)
        {
            race = Race;
        }

        public PlayerStats GetStats()
        {
            switch (race)
            {
                case RaceType.Elf:
                    return new PlayerStats()
                    {
                        Strenght = 5,
                        Intelligence = 10,
                        Stamina = 7
                    };

                case RaceType.Human:
                    return new PlayerStats()
                    {
                        Strenght = 7,
                        Intelligence = 7,
                        Stamina = 5
                    };

                case RaceType.Orc:
                    return new PlayerStats()
                    {
                        Strenght = 10,
                        Intelligence = 5,
                        Stamina = 10
                    };

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
