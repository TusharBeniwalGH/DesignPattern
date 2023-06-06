

namespace Builder
{
    public class BeverageDirector
    {
        public Beverage MakeBeverage(BeverageBuilder beverageBuilder)
        {
            beverageBuilder.CreateBeverage();

            beverageBuilder.SetWater();
            beverageBuilder.SetMilk();
            beverageBuilder.SetSugar();
            beverageBuilder.SetPowderQuantity();
            beverageBuilder.SetBeverageType();

            return beverageBuilder.GetBeverage();

        }
    }
}
