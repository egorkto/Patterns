using System;

namespace Singleton
{
    public class Cook
    {
        public void CookFood(Recipe recipe)
        {
            Console.WriteLine("Приготовил " + recipe.Name);
        }
    }
}
