using System;

namespace Composite
{
    class Product : Ingredient
    {
        public Product(string _name) : base(_name) { }

        public override void AddIngredient(Ingredient ingredient)
        {
            throw new InvalidOperationException();
        }
    }
}
