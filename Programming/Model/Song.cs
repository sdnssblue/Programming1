namespace Programming.Model
{
    public class Song
    {
        private int _durationSeconds;

        public Song()
        {

        }

        public Song(string author,
                    string songName,
                    int durationSeconds)
        {
            Author = author;
            SongName = songName;
            DurationSeconds = durationSeconds;
        }

        public string Author { get; set;}

        public string SongName {get; set;}

        public int DurationSeconds
        {
            get
            {
                return _durationSeconds;
            }
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException(
                        "the value of the Duration Seconds field must be greater than zero");
                }
                _durationSeconds = value;
            }
        }
    }
}
