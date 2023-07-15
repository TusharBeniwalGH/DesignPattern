namespace Decorator
{
   public class ChickenPizzaDecorator : PizzaDecorator
   {
      public ChickenPizzaDecorator(IPizza pizza) : base(pizza)
      {

      }

      public override string MakePizza()
      {
         return base.MakePizza() + AddChicken();
      }

      private static string AddChicken()
      {
         return ", Chicken";
      }
   }

}