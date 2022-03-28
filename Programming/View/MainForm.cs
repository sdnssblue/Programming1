using Programming.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        Color ErrorColor = Color.LightPink;

        Color CorrectColor = Color.White;

        const int CountElements = 5;

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        private Random _randomValues;


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


            _randomValues = new Random();
            _rectangles = new Rectangle[CountElements];
            var colors = Enum.GetValues(typeof(Colors));
            for (int i = 0; i < CountElements; i++)
            {
                _currentRectangle = new Rectangle();
                _currentRectangle.Width = _randomValues.Next(1, 101) / 10.0;
                _currentRectangle.Length = _randomValues.Next(1, 101) / 10.0;
                _currentRectangle.Color = colors.GetValue(_randomValues.Next(0, colors.Length)).ToString();
                _rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
            RectanglesListBox.SelectedIndex = 0;
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

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangle];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }
    }   
}
