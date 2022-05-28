using System;

namespace Programming.Model
{
    public class Movie
    {
        private static int _allMoviesCount;

        private int _releaseYear;

        private double _rating;

        private int _durationMinutes;

        private int _id;

        public Movie()
        {
            _allMoviesCount++;
            _id = _allMoviesCount;
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
            _allMoviesCount++;
            _id = _allMoviesCount;
        }

        public int Id => _id;

        public string Title { get; set; }

        public string Genre { get; set; }

        public int DurationMinutes
        {
            get => _durationMinutes;
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationMinutes), value);
                _durationMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get => _releaseYear;
            set
            {
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 1990, DateTime.Now.Year);
                _releaseYear = value;
            }
        }

        public double Rating
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(nameof(Rating), value, 0, 10);
                _rating = value;
            }
        }
    }
}
