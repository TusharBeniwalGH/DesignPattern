
namespace ChainOfResponseAbility
{
    public  class Purchase
    {
        int? number;
        double? amount;
        string? purpose;

        public Purchase(int? _number,double? _amount,string? _purchase)
        {
            this.number = _number;
            this.amount = _amount;
            this.purpose= _purchase;
        }
        public int? Number { get { return number; } set { number = value; } }

        public double? Amount { get { return amount; } set { amount = value; } }

        public string? Purpose { get { return purpose; } set { purpose = value; } }
    }
}
