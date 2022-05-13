using Programming.Model;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private const int ElementsCount = 5;

        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;

        private List<Rectangle> _rectangles;

        private Rectangle _currentRectangle;

        private Movie[] _movies;

        private Movie _currentMovie;

        private Random _random;

        public MainForm()
        {
            InitializeComponent();

            Array typeValues = Enum.GetValues(typeof(Enums));
            foreach (Enums value in typeValues)
            {
                EnumsListBox.Items.Add(value);
            }
            EnumsListBox.SelectedIndex = 0;

            Array seasons = Enum.GetValues(typeof(Seasons));
            foreach (Seasons value in seasons)
            {
                SeasonsComboBox.Items.Add(value);
            }
            SeasonsComboBox.SelectedIndex = 0;

            _random = new Random();

            //InitRectangles();
            _rectangles = new List<Rectangle>();
            InitMovies();
        }

        //private void InitRectangles()
        //{
        //    _rectangles = new List<Rectangle>();
        //    var colors = Enum.GetValues(typeof(Colors));
        //    for (int i = 0; i < ElementsCount; i++)
        //    {
        //        _currentRectangle = new Rectangle();
        //        _currentRectangle.Width = _random.Next(1, 101) / 10.0;
        //        _currentRectangle.Length = _random.Next(1, 101) / 10.0;
        //        _currentRectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
        //        _currentRectangle.Center = new Point2D(_random.Next(1, 100), _random.Next(1, 100));
        //        _rectangles.Add(_currentRectangle);
        //        RectangleListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
        //    }
        //    RectangleListBox.SelectedIndex = 0;
        //}

        private void InitMovies()
        {
            _movies = new Movie[ElementsCount];

            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _random.Next(101) / 10.0;
                _currentMovie.ReleaseYear = _random.Next(1990, DateTime.Now.Year);
                _currentMovie.Genre = genres.GetValue(_random.Next(0, genres.Length)).ToString();
                _currentMovie.Title = $"Movie {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _currentMovie.DurationMinutes = _random.Next(40, 200);
                _movies[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
            MovieListBox.SelectedIndex = 0;
        }

        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            int maxWidthIndex = 0;
            double max = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
        }

        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int maxRatingIndex = 0;
            double max = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                ValuesListBox.Items.Clear();
                Array enumValues;

                switch ((Enums)EnumsListBox.SelectedItem)
                {
                    case Enums.Weekday:
                        enumValues = Enum.GetValues(typeof(Weekday));
                        break;

                    case Enums.Genre:
                        enumValues = Enum.GetValues(typeof(Genre));
                        break;

                    case Enums.Colors:
                        enumValues = Enum.GetValues(typeof(Colors));
                        break;

                    case Enums.EducationForm:
                        enumValues = Enum.GetValues(typeof(EducationForm));
                        break;

                    case Enums.Smartphones:
                        enumValues = Enum.GetValues(typeof(Smartphones));
                        break;

                    case Enums.Seasons:
                        enumValues = Enum.GetValues(typeof(Seasons));
                        break;

                    default:
                        throw new NotImplementedException();
                }
                foreach (var value in enumValues)
                {
                    ValuesListBox.Items.Add(value);
                }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int) (ValuesListBox.SelectedItem)).ToString();
        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectangle = RectangleListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangle];
            RectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color;
            RectangleXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectangleYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void LengthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentLength = RectangleHeightTextBox.Text;
                int heightRectangle = int.Parse(currentLength);
                _currentRectangle.Height = heightRectangle;
            }
            catch
            {
                RectangleHeightTextBox.BackColor = _errorColor;
                return;
            }
            RectangleHeightTextBox.BackColor = _correctColor;
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentWidthRectangle = RectangleWidthTextBox.Text;
                int widthRectangle = int.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangle;
            }
            catch
            {
                RectangleWidthTextBox.BackColor = _errorColor;
                return;
            }
            RectangleWidthTextBox.BackColor = _correctColor;
        }

        private void ColorRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangle = RectangleColorTextBox.Text;
            _currentRectangle.Color = colorRectangle;
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = MovieListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndexMovie];
            MovieTitleTextBox.Text = _currentMovie.Title;
            MovieGenreTextBox.Text = _currentMovie.Genre;
            MovieReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieDurationMinutesTextBox.Text = _currentMovie.DurationMinutes.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void TitleMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            string titleMovie = MovieTitleTextBox.Text;
            _currentMovie.Title = titleMovie;
        }

        private void GenreMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            string genreMovie = MovieGenreTextBox.Text;
            _currentMovie.Genre = genreMovie;
        }

        private void RatingMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = MovieRatingTextBox.Text;
                double ratingMovie = double.Parse(currentRating);
                _currentMovie.Rating = ratingMovie;
            }
            catch
            {
                MovieRatingTextBox.BackColor = _errorColor;
                return;
            }
            MovieRatingTextBox.BackColor = _correctColor;
        }

        private void ReleaseYearMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentReleaseYear = MovieReleaseYearTextBox.Text;
                int releaseYearMovie = int.Parse(currentReleaseYear);
                _currentMovie.ReleaseYear = releaseYearMovie;
            }
            catch
            {
                MovieReleaseYearTextBox.BackColor = _errorColor;
                return;
            }
            MovieReleaseYearTextBox.BackColor = _correctColor;
        }

        private void DurationMinutesMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentDurationMinutes = MovieDurationMinutesTextBox.Text;
                int durationMinutesMovie = int.Parse(currentDurationMinutes);
                _currentMovie.DurationMinutes = durationMinutesMovie;
            }
            catch
            {
                MovieDurationMinutesTextBox.BackColor = _errorColor;
                return;
            }
            MovieDurationMinutesTextBox.BackColor = _correctColor;
        }

        private void WeekdayParseButton_Click(object sender, EventArgs e)
        {
            string textWeekdayTextBox = WeekdayTextBox.Text;
            Weekday weekday;
            if (Enum.TryParse(textWeekdayTextBox, out weekday))
            {
                OutputWeekdayLabel.Text = $"Это день недели ({weekday} - {(int)weekday})";
            }
            else
            {
                OutputWeekdayLabel.Text = "Нет такого дня недели";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonsComboBox.SelectedItem)
            {
                case Seasons.Winter:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Seasons.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Seasons.Summer:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Seasons.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox.SelectedIndex = findMaxWidthIndex;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            MovieListBox.SelectedIndex = findMaxRatingIndex;
        }

        private void UpdateRectanglesListBox(Rectangle rectangle)
        {
            int index = RectanglesListBox.FindString(rectangle.Id.ToString());

            if (index == -1) return;

            RectanglesListBox.Items[index] = $"{rectangle.Id}: " +
                                                  $"(X: {rectangle.Center.X};" +
                                                  $" Y: {rectangle.Center.Y};" +
                                                  $" W: {rectangle.Width};" +
                                                  $" H: {rectangle.Height})";
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            RemoveSelectedRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveSelectedRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var colors = Enum.GetValues(typeof(Colors));
            _currentRectangle = new Rectangle();
            _currentRectangle.Width = _random.Next(1, 101);
            _currentRectangle.Height = _random.Next(1, 101);
            _currentRectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            _currentRectangle.Center = new Point2D(_random.Next(1, 100), _random.Next(1, 100));
            _rectangles.Add(_currentRectangle);
            RectangleListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            RectanglesListBox.Items.Add($"{_currentRectangle.Id}: (X: {_currentRectangle.Center.X}; Y: {_currentRectangle.Center.Y}; W: {_currentRectangle.Width}; L: {_currentRectangle.Height})");
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = RectanglesListBox.SelectedIndex;
            if (index == -1) return;
            _rectangles.RemoveAt(index);
            RectanglesListBox.Items.Clear();
            RectangleListBox.Items.Clear();

            foreach (var rectangle in _rectangles)
            {
                RectanglesListBox.Items.Add($"{rectangle.Id}: (X: {rectangle.Center.X}; Y: {rectangle.Center.Y}; W: {rectangle.Width}; L: {rectangle.Height})");
                RectangleListBox.Items.Add($"Rectangle {rectangle.Id}");
                RectanglesListBox.SelectedIndex = 0;
            }
        }

        private void RectanglesXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string currentXRectangle = RectangleSelectedXTextBox.Text;
                int xRectangleValue = int.Parse(currentXRectangle);
                _currentRectangle.Center.X = xRectangleValue;
                UpdateRectanglesListBox(_currentRectangle);
            }
            catch
            {
                RectangleSelectedXTextBox.BackColor = _errorColor;
                return;
            }
            RectangleSelectedXTextBox.BackColor = _correctColor;
        }

        private void RectanglesYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string currentYRectangle = RectangleSelectedYTextBox.Text;
                int yRectangleValue = int.Parse(currentYRectangle);
                _currentRectangle.Center.Y = yRectangleValue;
                UpdateRectanglesListBox(_currentRectangle);
            }
            catch
            {
                RectangleSelectedYTextBox.BackColor = _errorColor;
                return;
            }
            RectangleSelectedYTextBox.BackColor = _correctColor;
        }

        private void RectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string currentWidthRectangle = RectangleSelectedWidthTextBox.Text;
                int widthRectangleValue = int.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangleValue;
                UpdateRectanglesListBox(_currentRectangle);
            }
            catch
            {
                RectangleSelectedWidthTextBox.BackColor = _errorColor;
                return;
            }
            RectangleSelectedWidthTextBox.BackColor = _correctColor;
        }

        private void RectanglesHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string currentHeightRectangle = RectangleSelectedHeightTextBox.Text;
                int heightRectangleValue = int.Parse(currentHeightRectangle);
                _currentRectangle.Height = heightRectangleValue;
                UpdateRectanglesListBox(_currentRectangle);
            }
            catch
            {
                RectangleSelectedHeightTextBox.BackColor = _errorColor;
                return;
            }
            RectangleSelectedHeightTextBox.BackColor = _correctColor;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem == null) return;

            int index = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[index];
            RectangleSelectedIdTextBox.Text = _currentRectangle.Id.ToString();
            RectangleSelectedXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectangleSelectedYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectangleSelectedWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleSelectedHeightTextBox.Text = _currentRectangle.Height.ToString();
        }
    }   
}
