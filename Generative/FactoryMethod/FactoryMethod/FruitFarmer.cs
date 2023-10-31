namespace FactoryMethod
{
    public class FruitFarmer : Farmer
    {
        public override Plant Grow(string name)
        {
            return new Fruit(name);
        }
    }
}
