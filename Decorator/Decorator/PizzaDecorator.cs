namespace Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string MakePizza()
        {
            return _pizza.MakePizza();
        }
    }
}