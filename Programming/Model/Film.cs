namespace Programming.Model
{
    public class Film
    {
        private int _yearRelease;
        private double _rating;
        private int _durationOfMinutes;

        public Film()
        {

        }

        public Film(int yearRelease,
                    int durationOfMinutes,
                    int rating,
                    string name,
                    string genre)
        {
            YearRelease = yearRelease;
            DurationOfMinutes = durationOfMinutes;
            Rating = rating;
            Name = name;
            Genre = genre;
        }

        public string Name {get; set;}

        public string Genre {get; set;}

        public int DurationOfMinutes
        {
            get
            {
                return _durationOfMinutes;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException(
                        "the duration of minutes field must be greater than 0");
                }
                _durationOfMinutes = value;
            }
        }

        public int YearRelease
        {
            get
            {
                return _yearRelease;
            }
            set
            {
                if (1900 > value || value > 2022)
                {
                    throw new System.ArgumentException(
                        "the release year should be in the range from 1900 to 2022");
                }
                _yearRelease = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (0 > value || value > 10)
                {
                    throw new System.ArgumentException(
                        "the rating should be in the range from 0 to 10");
                }
                _rating = value;
            }
        }
    }
}
