namespace Decorator
{
    public struct PlayerStats
    {
        public int Strenght { get; set; }
        public int Intelligence { get; set; }
        public int Stamina { get; set; }

        public static PlayerStats operator +(PlayerStats a, PlayerStats b)
        {
            return new PlayerStats()
            {
                Strenght = a.Strenght + b.Strenght,
                Intelligence = a.Intelligence + b.Intelligence,
                Stamina = a.Stamina + b.Stamina
            };
        }

        public static PlayerStats operator *(PlayerStats a, PlayerStats b)
        {
            return new PlayerStats()
            {
                Strenght = a.Strenght * b.Strenght,
                Intelligence = a.Intelligence * b.Intelligence,
                Stamina = a.Stamina * b.Stamina
            };
        }
    }
}
