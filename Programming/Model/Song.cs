using System;

namespace Programming.Model
{
    public class Song
    {
        private int _durationSeconds;

        public Song()
        {

        }

        public Song(string author,
                    string name,
                    int durationSeconds)
        {
            Author = author;
            Name = name;
            DurationSeconds = durationSeconds;
        }

        public string Author { get; set; }

        public string Name { get; set; }

        public int DurationSeconds
        {
            get => _durationSeconds;
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationSeconds), value);
                _durationSeconds = value;
            }
        }
    }
}
