using System;

namespace Programming.Model
{
    public class Time
    {
        private int _hours;

        private int _minutes;

        private int _seconds;

        public Time()
        {

        }

        public Time(int hours,
                    int minutes,
                    int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int Hours
        {
            get => _hours;
            set
            {
                if (0 > value || value > 23)
                {
                    throw new ArgumentException(
                        "the value of the hours field must be in the range from 0 to 23");
                }
                _hours = value;
            }
        }

        public int Minutes
        {
            get => _minutes;
            set
            {
                if (0 > value || value > 59)
                {
                    throw new ArgumentOutOfRangeException(
                        "the value of the minutes field must be in the range from 0 to 60");
                }
                _minutes = value;
            }
        }

        public int Seconds
        {
            get => _seconds;
            set
            {
                if (0 > value || value > 59)
                {
                    throw new ArgumentOutOfRangeException(
                        "the value of the seconds field must be in the range from 0 to 60");
                }
                _seconds = value;
            }
        }
    }
}
