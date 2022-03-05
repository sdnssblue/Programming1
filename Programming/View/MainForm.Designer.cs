
namespace Programming
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IntValueBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.OutputWeekdayLabel = new System.Windows.Forms.Label();
            this.WeekdayParseButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SeasonsComboBox = new System.Windows.Forms.ComboBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(814, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IntValueBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ValuesListBox);
            this.groupBox1.Controls.Add(this.EnumsListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumerations";
            // 
            // IntValueBox
            // 
            this.IntValueBox.Location = new System.Drawing.Point(335, 51);
            this.IntValueBox.Name = "IntValueBox";
            this.IntValueBox.Size = new System.Drawing.Size(91, 22);
            this.IntValueBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Int Value";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(171, 51);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(137, 228);
            this.ValuesListBox.TabIndex = 3;
            this.ValuesListBox.Click += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Location = new System.Drawing.Point(9, 51);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(137, 228);
            this.EnumsListBox.TabIndex = 2;
            this.EnumsListBox.Click += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Enumeration";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WeekdayParseButton);
            this.groupBox2.Controls.Add(this.OutputWeekdayLabel);
            this.groupBox2.Controls.Add(this.WeekdayTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weekday Parsing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type Value for Parsing";
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(9, 61);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(299, 22);
            this.WeekdayTextBox.TabIndex = 6;
            // 
            // OutputWeekdayLabel
            // 
            this.OutputWeekdayLabel.AutoSize = true;
            this.OutputWeekdayLabel.Location = new System.Drawing.Point(6, 86);
            this.OutputWeekdayLabel.Name = "OutputWeekdayLabel";
            this.OutputWeekdayLabel.Size = new System.Drawing.Size(0, 17);
            this.OutputWeekdayLabel.TabIndex = 7;
            // 
            // WeekdayParseButton
            // 
            this.WeekdayParseButton.Location = new System.Drawing.Point(314, 60);
            this.WeekdayParseButton.Name = "WeekdayParseButton";
            this.WeekdayParseButton.Size = new System.Drawing.Size(75, 23);
            this.WeekdayParseButton.TabIndex = 8;
            this.WeekdayParseButton.Text = "Parse";
            this.WeekdayParseButton.UseVisualStyleBackColor = true;
            this.WeekdayParseButton.Click += new System.EventHandler(this.WeekdayParseButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GoButton);
            this.groupBox3.Controls.Add(this.SeasonsComboBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(407, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 177);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Season Handle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Choose Season";
            // 
            // SeasonsComboBox
            // 
            this.SeasonsComboBox.FormattingEnabled = true;
            this.SeasonsComboBox.Location = new System.Drawing.Point(9, 58);
            this.SeasonsComboBox.Name = "SeasonsComboBox";
            this.SeasonsComboBox.Size = new System.Drawing.Size(299, 24);
            this.SeasonsComboBox.TabIndex = 3;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(314, 57);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 9;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming";
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IntValueBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ComboBox SeasonsComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button WeekdayParseButton;
        private System.Windows.Forms.Label OutputWeekdayLabel;
        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.Label label4;
    }
}

