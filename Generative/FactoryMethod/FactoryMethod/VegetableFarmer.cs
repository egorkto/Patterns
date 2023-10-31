namespace FactoryMethod
{
    public class VegetableFarmer : Farmer
    {
        public override Plant Grow(string name)
        {
            return new Fruit(name);
        }
    }
}
