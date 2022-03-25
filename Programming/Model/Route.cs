namespace Programming.Model
{
    public class Route
    {
        private int _flightTimeOfMinutes;

        public Route()
        {

        }

        public Route(string departurePoint,
                     string destinationPoint,
                     int flightTimeOfMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeOfMinutes = flightTimeOfMinutes;
        }

        public string DeparturePoint {get; set;}

        public string DestinationPoint {get; set;}

        public int FlightTimeOfMinutes
        {
            get
            {
                return _flightTimeOfMinutes;
            }
            set

            {
                if (value <= 0)
                {
                    throw new System.ArgumentException(
                        "the flight time of minutes field must be greater than 0");
                }
                _flightTimeOfMinutes = value;
            }
        }
    }
}
