using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var cook = new Cook();
            cook.CookFood(RecipeBook.Instance.recipes[0]);
            cook.CookFood(RecipeBook.Instance.recipes[3]);
            cook.CookFood(RecipeBook.Instance.recipes[1]);
            cook.CookFood(RecipeBook.Instance.recipes[2]);
        }
    }
}
