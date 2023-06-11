namespace Factory
{
    public class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public string GetCardType()
        {
            return "Platinum Plus";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }
}
