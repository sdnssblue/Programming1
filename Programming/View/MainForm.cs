using Programming.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using Color = Programming.Model.Color;

namespace Programming
{
    public partial class MainForm : Form
    {
        public enum Enums
        {
            Weekday,
            Genre,
            Color,
            EducationForm,
            Smartphones,
            Seasons
        }

        public MainForm()
        {
            InitializeComponent();

            EnumsListBox.Items.Add(Enums.Color);
            EnumsListBox.Items.Add(Enums.EducationForm);
            EnumsListBox.Items.Add(Enums.Genre);
            EnumsListBox.Items.Add(Enums.Seasons);
            EnumsListBox.Items.Add(Enums.Smartphones);
            EnumsListBox.Items.Add(Enums.Weekday);

            Array initSeasonValues = Enum.GetValues(typeof(Seasons));
            foreach (Seasons value in initSeasonValues)
            {
                SeasonsComboBox.Items.Add(value);
            }
            SeasonsComboBox.SelectedIndex = 0;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                ValuesListBox.Items.Clear();

                Array EnumValue;

                switch ((Enums)EnumsListBox.SelectedItem)
                {
                    case Enums.Weekday:
                        EnumValue = Enum.GetValues(typeof(Weekday));
                        foreach (Weekday value in EnumValue)
                        {
                            ValuesListBox.Items.Add(value);
                        }
                        break;

                    case Enums.Genre:
                        EnumValue = Enum.GetValues(typeof(Genre));
                        foreach (Genre value in EnumValue)
                        {
                            ValuesListBox.Items.Add(value);
                        }
                        break;

                    case Enums.Color:
                        EnumValue = Enum.GetValues(typeof(Color));
                        foreach (Color value in EnumValue)
                        {
                            ValuesListBox.Items.Add(value);
                        }
                        break;

                    case Enums.EducationForm:
                        EnumValue = Enum.GetValues(typeof(EducationForm));
                        foreach (EducationForm value in EnumValue)
                        {
                            ValuesListBox.Items.Add(value);
                        }
                        break;

                    case Enums.Smartphones:
                        EnumValue = Enum.GetValues(typeof(Smartphones));
                        foreach (Smartphones value in EnumValue)
                        {
                            ValuesListBox.Items.Add(value);
                        }
                        break;

                    case Enums.Seasons:
                        EnumValue = Enum.GetValues(typeof(Seasons));
                        foreach (Seasons value in EnumValue)
                        {
                            ValuesListBox.Items.Add(value);
                        }
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueBox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void WeekdayParseButton_Click(object sender, EventArgs e)
        {
            string textWeekdayTextBox = WeekdayTextBox.Text;
            Weekday value;
            if (Enum.TryParse(textWeekdayTextBox, out value))
            {
                OutputWeekdayLabel.Text = $"Это день недели ({value} - {(int)value + 1})";
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
    }
}
