using System;

namespace Programming.Model
{
    public class Route
    {
        private int _flightTimeMinutes;

        public Route()
        {

        }

        public Route(string departure,
                     string destination,
                     int flightTimeMinutes)
        {
            Departure = departure;
            Destination = destination;
            FlightTimeMinutes = flightTimeMinutes;
        }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public int FlightTimeMinutes
        {
            get => _flightTimeMinutes;
            set
            {
                Validator.AssertOnPositiveValue(nameof(FlightTimeMinutes), value);
                _flightTimeMinutes = value;
            }
        }
    }
}
