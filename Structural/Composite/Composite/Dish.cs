using System.Collections.Generic;

namespace Composite
{
    class Dish : Ingredient
    {
        private List<Ingredient> products;

        public Dish(string _name) : base(_name) 
        {
            products = new List<Ingredient>();
        }

        public override void AddIngredient(Ingredient ingredient)
        {
            products.Add(ingredient);
        }
    }
}
