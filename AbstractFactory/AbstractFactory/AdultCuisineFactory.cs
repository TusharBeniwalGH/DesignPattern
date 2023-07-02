

namespace AbstractFactory
{
    public class AdultCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new CremeBrulee();
        }

        public override Sandwich CreateSandwich()
        {
            return new BLT();
        }
    }
}
