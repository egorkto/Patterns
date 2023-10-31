using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingredient tomato = new Product("Помидор");
            Ingredient cucumber = new Product("Огурец");
            Ingredient salad = new Dish("Салат");

            salad.AddIngredient(tomato);
            salad.AddIngredient(cucumber);

            Console.WriteLine(tomato);
            Console.WriteLine(cucumber);
            Console.WriteLine(salad);
        }
    }
}
