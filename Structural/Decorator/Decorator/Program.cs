using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player(RaceType.Elf, Specialization.Warrior);
            Console.WriteLine(player);
        }
    }

    public enum RaceType
    {
        Orc,
        Human,
        Elf
    }

    public enum Specialization
    {
        Warrior,
        Wizard,
        Thief
    }
}
