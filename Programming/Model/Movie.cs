using System;

namespace Programming.Model
{
    public class Movie
    {
        private int _releaseYear;

        private double _rating;

        private int _durationMinutes;

        public Movie()
        {

        }

        public Movie(int releaseYear,
                    int durationMinutes,
                    int rating,
                    string title,
                    string genre)
        {
            ReleaseYear = releaseYear;
            DurationMinutes = durationMinutes;
            Rating = rating;
            Title = title;
            Genre = genre;
        }

        public string Title { get; set; }

        public string Genre { get; set; }

        public int DurationMinutes
        {
            get => _durationMinutes;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "the duration of minutes field must be greater than 0");
                }
                _durationMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get => _releaseYear;
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException
                        ($"the release year should be in the range from 1900 to {DateTime.Now.Year}");
                }
                _releaseYear = value;
            }
        }

        public double Rating
        {
            get => _rating;
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException(
                        "the rating should be in the range from 0 to 10");
                }
                _rating = value;
            }
        }
    }
}
