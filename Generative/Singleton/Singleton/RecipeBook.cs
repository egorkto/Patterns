namespace Singleton
{
    public class RecipeBook
    {
        public static RecipeBook Instance => instance;
        public readonly Recipe[] recipes;

        private static RecipeBook instance = new RecipeBook();

        public RecipeBook()
        {
            recipes = new Recipe[] 
            {
                new Recipe("Яичница"),
                new Recipe("Стейк"),
                new Recipe("Салат"),
                new Recipe("Ребрышки")
            };
        }

    }
}
