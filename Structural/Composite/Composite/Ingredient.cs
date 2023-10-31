namespace Composite
{
    public abstract class Ingredient
    {
        public string Name { get; private set; }

        public Ingredient(string _name)
        {
            Name = _name;
        }

        public abstract void AddIngredient(Ingredient ingredient);

        public override string ToString()
        {
            return Name;
        }
    }
}
