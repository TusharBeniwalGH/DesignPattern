namespace Decorator
{
    public class PlainPizza : IPizza
    {
        public string MakePizza()
        {
            return "Plain Pizza";
        }
    }
}