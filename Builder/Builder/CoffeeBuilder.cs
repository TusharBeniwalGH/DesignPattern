
namespace Builder
{
    public class CoffeeBuilder : BeverageBuilder
    {
        public override void SetBeverageType()
        {
            

            if (beverage!=null)
            beverage.BeverageName = "Coffee";
        }

        public override void SetMilk()
        {
            Console.WriteLine("Step 2: Adding Milk");

            if (beverage != null)
                beverage.Milk = 50;
        }

        public override void SetPowderQuantity()
        {
            Console.WriteLine("Step 4: Adding 15 gram of coffee powder");

            if (beverage != null)
                beverage.PowderQuantity = 15;
        }

        public override void SetSugar()
        {
            Console.WriteLine("Step 3: Adding Sugar");

            if (beverage != null)
                beverage.Sugar = 10;
        }

        public override void SetWater()
        {
            Console.WriteLine("Step 1 : Boiling water");
            if (beverage != null)
                beverage.Water = 40;
        }
    }
}
