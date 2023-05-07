

namespace ChainOfResponseAbility
{
    public abstract class Approver
    {
        protected Approver? _successor;

        public void SetSucessor(Approver? sucessor)
        {
            _successor = sucessor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
