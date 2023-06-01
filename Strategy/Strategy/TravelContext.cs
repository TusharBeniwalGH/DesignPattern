

namespace Strategy
{
    public class TravelContext
    {
        private ITravelStrategy? _strategy;

        public void SetTravelStrategy(ITravelStrategy strategy)
        {
            _strategy = strategy;
        }

        public void GoToAirport()
        {
            if (_strategy != null)
            _strategy.GoToAirport();
        }
    }
}
