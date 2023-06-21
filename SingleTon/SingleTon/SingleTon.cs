
namespace SingleTon
{
    public sealed  class SingleTon
    {
        private static int Counter = 0;

        private static SingleTon Instance = null;

        private static readonly object Instancelock = new object();

        public static SingleTon GetInstance()
        {
            if (Instance == null)
            { 

            lock (Instancelock)
            {
                if (Instance == null)
                    Instance = new SingleTon();
            }

           }
            return Instance;
        }

        private SingleTon()
        {
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
