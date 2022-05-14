using System;
using Programming.Model;
using Programming.Model.Enums;
using Programming.Model.Geometry;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private const int ElementsCount = 5;

        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;

        private readonly Color _inContact = Color.FromArgb(127, 255, 127, 127);

        private readonly Color _unContact = Color.FromArgb(127, 127, 255, 127);

        private List<Rectangle> _rectangles;

        private List<Panel> _rectanglePanels;

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

            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();

            InitMovies();
        }

        private void ClearRectangleInfo()
        {
            RectanglesListBox.Items.Clear();
            RectangleListBox.Items.Clear();

            RectangleSelectedIdTextBox.Clear();
            RectangleSelectedXTextBox.Clear();
            RectangleSelectedYTextBox.Clear();
            RectangleSelectedWidthTextBox.Clear();
            RectangleSelectedHeightTextBox.Clear();

            RectangleWidthTextBox.Clear();
            RectangleHeightTextBox.Clear();
            RectangleColorTextBox.Clear();
            RectangleIdTextBox.Clear();
            RectangleXTextBox.Clear();
            RectangleYTextBox.Clear();
        }

        private string RectangleParameters(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X: {rectangle.Center.X};" +
                   $" Y: {rectangle.Center.Y};" +
                   $" W: {rectangle.Width};" +
                   $" H: {rectangle.Height})";
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = RectanglesListBox.FindString(rectangle.Id.ToString());

            if (index == -1) return;

            RectanglesListBox.Items[index] = RectangleParameters(rectangle);
        }

        private Panel InitPanel()
        {
            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = _currentRectangle.Width;
            rectanglePanel.Height = _currentRectangle.Height;
            rectanglePanel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            rectanglePanel.BackColor = _unContact;

            return rectanglePanel;
        }

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

        private void FindCollisions()
        {
            for (int k = 0; k < _rectangles.Count; k++)
            {
                CanvasPanel.Controls[k].BackColor = _unContact;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = _inContact;
                        CanvasPanel.Controls[j].BackColor = _inContact;
                    }
                }
            }
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

        private void HeightRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1) return;

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
            if (RectangleListBox.SelectedIndex == -1) return;

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

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveSelectedRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveSelectedRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            _rectangles.Add(_currentRectangle);
            RectangleListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            RectanglesListBox.Items.Add(RectangleParameters(_currentRectangle));

            Panel rectanglePanel = InitPanel();
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);
            FindCollisions();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = RectanglesListBox.SelectedIndex;

            if (index == -1) return;

            _rectangles.RemoveAt(index);
            _rectanglePanels.RemoveAt(index);
            CanvasPanel.Controls.RemoveAt(index);

            ClearRectangleInfo();

            foreach (var rectangle in _rectangles)
            {
                RectanglesListBox.Items.Add(RectangleParameters(rectangle));
                RectangleListBox.Items.Add($"Rectangle {rectangle.Id}");
                RectanglesListBox.SelectedIndex = 0;
            }

            FindCollisions();
        }

        private void RectanglesXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string currentXRectangle = RectangleSelectedXTextBox.Text;
                int xRectangleValue = int.Parse(currentXRectangle);
                _currentRectangle.Center.X = xRectangleValue;
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
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
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
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
                UpdateRectangleInfo(_currentRectangle);
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Width = _currentRectangle.Width;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
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
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Height = _currentRectangle.Height;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
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
