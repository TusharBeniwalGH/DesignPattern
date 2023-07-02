
namespace AbstractFactory
{
    public class KidCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new IceCreamSundae();
        }

        public override Sandwich CreateSandwich()
        {
            return new GrilledCheese();
        }
    }
}
