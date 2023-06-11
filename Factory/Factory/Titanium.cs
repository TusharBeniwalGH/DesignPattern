namespace Factory
{
    internal class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }
    }
}
