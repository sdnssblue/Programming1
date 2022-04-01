
namespace Programming.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonsComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParseButton = new System.Windows.Forms.Button();
            this.OutputWeekdayLabel = new System.Windows.Forms.Label();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.ParsingLabel = new System.Windows.Forms.Label();
            this.EnumerationGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumerationLabel = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviesDurationLabel = new System.Windows.Forms.Label();
            this.DurationMinutesMovieTextBox = new System.Windows.Forms.TextBox();
            this.MoviesReleaseLabel = new System.Windows.Forms.Label();
            this.ReleaseYearMovieTextBox = new System.Windows.Forms.TextBox();
            this.MovieFindButton = new System.Windows.Forms.Button();
            this.MoviesRatingLabel = new System.Windows.Forms.Label();
            this.MoviesGenreLabel = new System.Windows.Forms.Label();
            this.MoviesTitleLabel = new System.Windows.Forms.Label();
            this.RatingMovieTextBox = new System.Windows.Forms.TextBox();
            this.GenreMovieTextBox = new System.Windows.Forms.TextBox();
            this.TitleMovieTextBox = new System.Windows.Forms.TextBox();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectangleFindButton = new System.Windows.Forms.Button();
            this.RectanglesColorLabel = new System.Windows.Forms.Label();
            this.RectanglesWidthLabel = new System.Windows.Forms.Label();
            this.RectanglesLengthLabel = new System.Windows.Forms.Label();
            this.ColorRectangleTextBox = new System.Windows.Forms.TextBox();
            this.WidthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.LengthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationGroupBox.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumerationGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.EnumsTabPage.Size = new System.Drawing.Size(656, 401);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonsComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(330, 252);
            this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(316, 144);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(236, 49);
            this.GoButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 9;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SeasonsComboBox
            // 
            this.SeasonsComboBox.FormattingEnabled = true;
            this.SeasonsComboBox.Location = new System.Drawing.Point(7, 50);
            this.SeasonsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonsComboBox.Name = "SeasonsComboBox";
            this.SeasonsComboBox.Size = new System.Drawing.Size(225, 21);
            this.SeasonsComboBox.TabIndex = 3;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(4, 33);
            this.SeasonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(83, 13);
            this.SeasonLabel.TabIndex = 2;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.OutputWeekdayLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingLabel);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(6, 252);
            this.WeekdayParsingGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(320, 144);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayParseButton
            // 
            this.WeekdayParseButton.Location = new System.Drawing.Point(236, 49);
            this.WeekdayParseButton.Margin = new System.Windows.Forms.Padding(2);
            this.WeekdayParseButton.Name = "WeekdayParseButton";
            this.WeekdayParseButton.Size = new System.Drawing.Size(75, 23);
            this.WeekdayParseButton.TabIndex = 8;
            this.WeekdayParseButton.Text = "Parse";
            this.WeekdayParseButton.UseVisualStyleBackColor = true;
            this.WeekdayParseButton.Click += new System.EventHandler(this.WeekdayParseButton_Click);
            // 
            // OutputWeekdayLabel
            // 
            this.OutputWeekdayLabel.AutoSize = true;
            this.OutputWeekdayLabel.Location = new System.Drawing.Point(4, 70);
            this.OutputWeekdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutputWeekdayLabel.Name = "OutputWeekdayLabel";
            this.OutputWeekdayLabel.Size = new System.Drawing.Size(0, 13);
            this.OutputWeekdayLabel.TabIndex = 7;
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(7, 50);
            this.WeekdayTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(225, 20);
            this.WeekdayTextBox.TabIndex = 6;
            // 
            // ParsingLabel
            // 
            this.ParsingLabel.AutoSize = true;
            this.ParsingLabel.Location = new System.Drawing.Point(4, 33);
            this.ParsingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ParsingLabel.Name = "ParsingLabel";
            this.ParsingLabel.Size = new System.Drawing.Size(115, 13);
            this.ParsingLabel.TabIndex = 1;
            this.ParsingLabel.Text = "Type value for parsing:";
            // 
            // EnumerationGroupBox
            // 
            this.EnumerationGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumerationGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationGroupBox.Controls.Add(this.ChooseValueLabel);
            this.EnumerationGroupBox.Controls.Add(this.ChooseEnumerationLabel);
            this.EnumerationGroupBox.Location = new System.Drawing.Point(6, 6);
            this.EnumerationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumerationGroupBox.Name = "EnumerationGroupBox";
            this.EnumerationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.EnumerationGroupBox.Size = new System.Drawing.Size(640, 240);
            this.EnumerationGroupBox.TabIndex = 0;
            this.EnumerationGroupBox.TabStop = false;
            this.EnumerationGroupBox.Text = "Enumerations";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(251, 41);
            this.IntValueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.ReadOnly = true;
            this.IntValueTextBox.Size = new System.Drawing.Size(69, 20);
            this.IntValueTextBox.TabIndex = 5;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(249, 25);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(51, 13);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(128, 41);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(104, 186);
            this.ValuesListBox.TabIndex = 3;
            this.ValuesListBox.Click += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(7, 41);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(104, 186);
            this.EnumsListBox.TabIndex = 2;
            this.EnumsListBox.Click += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(126, 25);
            this.ChooseValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ChooseValueLabel.TabIndex = 1;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumerationLabel
            // 
            this.ChooseEnumerationLabel.AutoSize = true;
            this.ChooseEnumerationLabel.Location = new System.Drawing.Point(4, 25);
            this.ChooseEnumerationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            this.ChooseEnumerationLabel.Size = new System.Drawing.Size(107, 13);
            this.ChooseEnumerationLabel.TabIndex = 0;
            this.ChooseEnumerationLabel.Text = "Choose enumeration:";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsTabPage);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(664, 427);
            this.TabControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(656, 401);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.MoviesDurationLabel);
            this.MoviesGroupBox.Controls.Add(this.DurationMinutesMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.MoviesReleaseLabel);
            this.MoviesGroupBox.Controls.Add(this.ReleaseYearMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieFindButton);
            this.MoviesGroupBox.Controls.Add(this.MoviesRatingLabel);
            this.MoviesGroupBox.Controls.Add(this.MoviesGenreLabel);
            this.MoviesGroupBox.Controls.Add(this.MoviesTitleLabel);
            this.MoviesGroupBox.Controls.Add(this.RatingMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.GenreMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.TitleMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieListBox);
            this.MoviesGroupBox.Location = new System.Drawing.Point(330, 6);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(312, 387);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // MoviesDurationLabel
            // 
            this.MoviesDurationLabel.AutoSize = true;
            this.MoviesDurationLabel.Location = new System.Drawing.Point(191, 219);
            this.MoviesDurationLabel.Name = "MoviesDurationLabel";
            this.MoviesDurationLabel.Size = new System.Drawing.Size(50, 13);
            this.MoviesDurationLabel.TabIndex = 9;
            this.MoviesDurationLabel.Text = "Duration:";
            // 
            // DurationMinutesMovieTextBox
            // 
            this.DurationMinutesMovieTextBox.Location = new System.Drawing.Point(191, 235);
            this.DurationMinutesMovieTextBox.Name = "DurationMinutesMovieTextBox";
            this.DurationMinutesMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.DurationMinutesMovieTextBox.TabIndex = 8;
            this.DurationMinutesMovieTextBox.TextChanged += new System.EventHandler(this.DurationMinutesMovieTextBox_TextChanged);
            // 
            // MoviesReleaseLabel
            // 
            this.MoviesReleaseLabel.AutoSize = true;
            this.MoviesReleaseLabel.Location = new System.Drawing.Point(191, 170);
            this.MoviesReleaseLabel.Name = "MoviesReleaseLabel";
            this.MoviesReleaseLabel.Size = new System.Drawing.Size(72, 13);
            this.MoviesReleaseLabel.TabIndex = 7;
            this.MoviesReleaseLabel.Text = "Release year:";
            // 
            // ReleaseYearMovieTextBox
            // 
            this.ReleaseYearMovieTextBox.Location = new System.Drawing.Point(191, 186);
            this.ReleaseYearMovieTextBox.Name = "ReleaseYearMovieTextBox";
            this.ReleaseYearMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.ReleaseYearMovieTextBox.TabIndex = 6;
            this.ReleaseYearMovieTextBox.TextChanged += new System.EventHandler(this.YearReleaseMovieTextBox_TextChanged);
            // 
            // MovieFindButton
            // 
            this.MovieFindButton.Location = new System.Drawing.Point(191, 286);
            this.MovieFindButton.Name = "MovieFindButton";
            this.MovieFindButton.Size = new System.Drawing.Size(100, 23);
            this.MovieFindButton.TabIndex = 1;
            this.MovieFindButton.Text = "Find";
            this.MovieFindButton.UseVisualStyleBackColor = true;
            this.MovieFindButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // MoviesRatingLabel
            // 
            this.MoviesRatingLabel.AutoSize = true;
            this.MoviesRatingLabel.Location = new System.Drawing.Point(191, 120);
            this.MoviesRatingLabel.Name = "MoviesRatingLabel";
            this.MoviesRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.MoviesRatingLabel.TabIndex = 5;
            this.MoviesRatingLabel.Text = "Rating:";
            // 
            // MoviesGenreLabel
            // 
            this.MoviesGenreLabel.AutoSize = true;
            this.MoviesGenreLabel.Location = new System.Drawing.Point(191, 72);
            this.MoviesGenreLabel.Name = "MoviesGenreLabel";
            this.MoviesGenreLabel.Size = new System.Drawing.Size(39, 13);
            this.MoviesGenreLabel.TabIndex = 4;
            this.MoviesGenreLabel.Text = "Genre:";
            // 
            // MoviesTitleLabel
            // 
            this.MoviesTitleLabel.AutoSize = true;
            this.MoviesTitleLabel.Location = new System.Drawing.Point(191, 23);
            this.MoviesTitleLabel.Name = "MoviesTitleLabel";
            this.MoviesTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.MoviesTitleLabel.TabIndex = 1;
            this.MoviesTitleLabel.Text = "Title:";
            // 
            // RatingMovieTextBox
            // 
            this.RatingMovieTextBox.Location = new System.Drawing.Point(191, 136);
            this.RatingMovieTextBox.Name = "RatingMovieTextBox";
            this.RatingMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingMovieTextBox.TabIndex = 3;
            this.RatingMovieTextBox.TextChanged += new System.EventHandler(this.RatingMovieTextBox_TextChanged);
            // 
            // GenreMovieTextBox
            // 
            this.GenreMovieTextBox.Location = new System.Drawing.Point(191, 88);
            this.GenreMovieTextBox.Name = "GenreMovieTextBox";
            this.GenreMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreMovieTextBox.TabIndex = 2;
            this.GenreMovieTextBox.TextChanged += new System.EventHandler(this.GenreMovieTextBox_TextChanged);
            // 
            // TitleMovieTextBox
            // 
            this.TitleMovieTextBox.Location = new System.Drawing.Point(191, 39);
            this.TitleMovieTextBox.Name = "TitleMovieTextBox";
            this.TitleMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleMovieTextBox.TabIndex = 1;
            this.TitleMovieTextBox.TextChanged += new System.EventHandler(this.TitleMovieTextBox_TextChanged);
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.Location = new System.Drawing.Point(6, 19);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(179, 290);
            this.MovieListBox.TabIndex = 0;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.RectangleFindButton);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesWidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesLengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.ColorRectangleTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthRectangleTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthRectangleTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleListBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(6, 6);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(312, 387);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectangleFindButton
            // 
            this.RectangleFindButton.Location = new System.Drawing.Point(191, 286);
            this.RectangleFindButton.Name = "RectangleFindButton";
            this.RectangleFindButton.Size = new System.Drawing.Size(100, 23);
            this.RectangleFindButton.TabIndex = 1;
            this.RectangleFindButton.Text = "Find";
            this.RectangleFindButton.UseVisualStyleBackColor = true;
            this.RectangleFindButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // RectanglesColorLabel
            // 
            this.RectanglesColorLabel.AutoSize = true;
            this.RectanglesColorLabel.Location = new System.Drawing.Point(191, 120);
            this.RectanglesColorLabel.Name = "RectanglesColorLabel";
            this.RectanglesColorLabel.Size = new System.Drawing.Size(34, 13);
            this.RectanglesColorLabel.TabIndex = 5;
            this.RectanglesColorLabel.Text = "Color:";
            // 
            // RectanglesWidthLabel
            // 
            this.RectanglesWidthLabel.AutoSize = true;
            this.RectanglesWidthLabel.Location = new System.Drawing.Point(191, 72);
            this.RectanglesWidthLabel.Name = "RectanglesWidthLabel";
            this.RectanglesWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.RectanglesWidthLabel.TabIndex = 4;
            this.RectanglesWidthLabel.Text = "Width:";
            // 
            // RectanglesLengthLabel
            // 
            this.RectanglesLengthLabel.AutoSize = true;
            this.RectanglesLengthLabel.Location = new System.Drawing.Point(191, 23);
            this.RectanglesLengthLabel.Name = "RectanglesLengthLabel";
            this.RectanglesLengthLabel.Size = new System.Drawing.Size(43, 13);
            this.RectanglesLengthLabel.TabIndex = 1;
            this.RectanglesLengthLabel.Text = "Length:";
            // 
            // ColorRectangleTextBox
            // 
            this.ColorRectangleTextBox.Location = new System.Drawing.Point(191, 136);
            this.ColorRectangleTextBox.Name = "ColorRectangleTextBox";
            this.ColorRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorRectangleTextBox.TabIndex = 3;
            this.ColorRectangleTextBox.TextChanged += new System.EventHandler(this.ColorRectangleTextBox_TextChanged);
            // 
            // WidthRectangleTextBox
            // 
            this.WidthRectangleTextBox.Location = new System.Drawing.Point(191, 88);
            this.WidthRectangleTextBox.Name = "WidthRectangleTextBox";
            this.WidthRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthRectangleTextBox.TabIndex = 2;
            this.WidthRectangleTextBox.TextChanged += new System.EventHandler(this.WidthRectangleTextBox_TextChanged);
            // 
            // LengthRectangleTextBox
            // 
            this.LengthRectangleTextBox.Location = new System.Drawing.Point(191, 39);
            this.LengthRectangleTextBox.Name = "LengthRectangleTextBox";
            this.LengthRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthRectangleTextBox.TabIndex = 1;
            this.LengthRectangleTextBox.TextChanged += new System.EventHandler(this.LengthRectangleTextBox_TextChanged);
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.Location = new System.Drawing.Point(6, 19);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(179, 290);
            this.RectangleListBox.TabIndex = 0;
            this.RectangleListBox.Click += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 427);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming";
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumerationGroupBox.ResumeLayout(false);
            this.EnumerationGroupBox.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.GroupBox EnumerationGroupBox;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.Label ChooseEnumerationLabel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ComboBox SeasonsComboBox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Button WeekdayParseButton;
        private System.Windows.Forms.Label OutputWeekdayLabel;
        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.Label ParsingLabel;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.ListBox RectangleListBox;
        private System.Windows.Forms.Button RectangleFindButton;
        private System.Windows.Forms.Label RectanglesColorLabel;
        private System.Windows.Forms.Label RectanglesWidthLabel;
        private System.Windows.Forms.Label RectanglesLengthLabel;
        private System.Windows.Forms.TextBox ColorRectangleTextBox;
        private System.Windows.Forms.TextBox WidthRectangleTextBox;
        private System.Windows.Forms.TextBox LengthRectangleTextBox;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.Button MovieFindButton;
        private System.Windows.Forms.Label MoviesRatingLabel;
        private System.Windows.Forms.Label MoviesGenreLabel;
        private System.Windows.Forms.Label MoviesTitleLabel;
        private System.Windows.Forms.TextBox RatingMovieTextBox;
        private System.Windows.Forms.TextBox GenreMovieTextBox;
        private System.Windows.Forms.TextBox TitleMovieTextBox;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.Label MoviesReleaseLabel;
        private System.Windows.Forms.TextBox ReleaseYearMovieTextBox;
        private System.Windows.Forms.Label MoviesDurationLabel;
        private System.Windows.Forms.TextBox DurationMinutesMovieTextBox;
    }
}

