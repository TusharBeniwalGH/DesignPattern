

namespace Strategy
{
    public class BusTravelStrategy : ITravelStrategy
    {
        public void GoToAirport()
        {
            Console.WriteLine("Traveler is going to Airport by Taxi and will be charged Rs 300");
        }
    }

}
