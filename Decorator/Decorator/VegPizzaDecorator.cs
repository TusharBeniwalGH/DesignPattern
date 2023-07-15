
namespace Decorator
{
    public class VegPizzaDecorator : PizzaDecorator
    {
        public VegPizzaDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string MakePizza()
        {
            return base.MakePizza() + AddVeg();
        }

        private static string AddVeg()
        {
            return ", Veg";
        }
    }
}