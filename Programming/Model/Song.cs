namespace Programming.Model
{
    public class Song
    {
        private int _durationOfSeconds;

        public Song()
        {

        }

        public Song(string musician,
                    string songName,
                    int durationOfSeconds)
        {
            Musician = musician;
            SongName = songName;
            DurationSeconds = durationOfSeconds;
        }

        public string Musician {get; set;}

        public string SongName {get; set;}

        public int DurationSeconds
        {
            get
            {
                return _durationOfSeconds;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException(
                        "the value of the Duration Seconds field must be greater than zero");
                }
                _durationOfSeconds = value;
            }
        }
    }
}
