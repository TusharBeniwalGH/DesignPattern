

namespace Builder
{
    public class TeaBuilder : BeverageBuilder
    {
        public override void SetBeverageType()
        {
         

            if (beverage != null)
                beverage.BeverageName = "Tea";
        }

        public override void SetMilk()
        {
            Console.WriteLine("Step 2: Adding Milk");

            if (beverage != null)
                beverage.Milk = 60;
        }

        public override void SetPowderQuantity()
        {
            Console.WriteLine("Step 4: Adding 30 gram of tea powder");

            if (beverage != null)
                beverage.PowderQuantity = 30;
        }

        public override void SetSugar()
        {
            Console.WriteLine("Step 3: Adding sugar");

            if (beverage != null)
                beverage.Sugar = 15;
        }

        public override void SetWater()
        {
            Console.WriteLine("Step 1: Boiling Water");

            if (beverage != null)
                beverage.Water = 50;
        }
    }
}
