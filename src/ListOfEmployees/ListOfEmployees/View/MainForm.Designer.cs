namespace ListOfEmployees.View
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
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.SelectedEmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PostTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.PostLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.RemoveEmployeeButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.SelectedEmployeeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.IntegralHeight = false;
            this.EmployeesListBox.Location = new System.Drawing.Point(8, 11);
            this.EmployeesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(252, 378);
            this.EmployeesListBox.TabIndex = 0;
            this.EmployeesListBox.SelectedIndexChanged += new System.EventHandler(this.ListBoxEmployees_SelectedIndexChanged);
            // 
            // SelectedEmployeeGroupBox
            // 
            this.SelectedEmployeeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedEmployeeGroupBox.Controls.Add(this.DateTimePicker);
            this.SelectedEmployeeGroupBox.Controls.Add(this.PostTextBox);
            this.SelectedEmployeeGroupBox.Controls.Add(this.SalaryTextBox);
            this.SelectedEmployeeGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedEmployeeGroupBox.Controls.Add(this.SalaryLabel);
            this.SelectedEmployeeGroupBox.Controls.Add(this.DateLabel);
            this.SelectedEmployeeGroupBox.Controls.Add(this.PostLabel);
            this.SelectedEmployeeGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedEmployeeGroupBox.Location = new System.Drawing.Point(271, 11);
            this.SelectedEmployeeGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SelectedEmployeeGroupBox.Name = "SelectedEmployeeGroupBox";
            this.SelectedEmployeeGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SelectedEmployeeGroupBox.Size = new System.Drawing.Size(395, 133);
            this.SelectedEmployeeGroupBox.TabIndex = 1;
            this.SelectedEmployeeGroupBox.TabStop = false;
            this.SelectedEmployeeGroupBox.Text = "Selected Employee";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(112, 75);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.DateTimePicker.TabIndex = 5;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // PostTextBox
            // 
            this.PostTextBox.Location = new System.Drawing.Point(112, 50);
            this.PostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.Size = new System.Drawing.Size(274, 20);
            this.PostTextBox.TabIndex = 7;
            this.PostTextBox.TextChanged += new System.EventHandler(this.PostTextBox_TextChanged);
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(112, 102);
            this.SalaryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(144, 20);
            this.SalaryTextBox.TabIndex = 6;
            this.SalaryTextBox.TextChanged += new System.EventHandler(this.SalaryTextBox_TextChanged);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(112, 24);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(274, 20);
            this.FullNameTextBox.TabIndex = 4;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(70, 104);
            this.SalaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(39, 13);
            this.SalaryLabel.TabIndex = 3;
            this.SalaryLabel.Text = "Salary:";
            this.SalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(4, 78);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(104, 13);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date of employment:";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PostLabel
            // 
            this.PostLabel.AutoSize = true;
            this.PostLabel.Location = new System.Drawing.Point(78, 52);
            this.PostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PostLabel.Name = "PostLabel";
            this.PostLabel.Size = new System.Drawing.Size(31, 13);
            this.PostLabel.TabIndex = 1;
            this.PostLabel.Text = "Post:";
            this.PostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(53, 26);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(55, 13);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full name:";
            this.FullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RemoveEmployeeButton
            // 
            this.RemoveEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveEmployeeButton.FlatAppearance.BorderSize = 0;
            this.RemoveEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveEmployeeButton.Image = global::ListOfEmployees.Properties.Resources.minus_24x24_uncolor;
            this.RemoveEmployeeButton.Location = new System.Drawing.Point(225, 393);
            this.RemoveEmployeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveEmployeeButton.Name = "RemoveEmployeeButton";
            this.RemoveEmployeeButton.Size = new System.Drawing.Size(35, 32);
            this.RemoveEmployeeButton.TabIndex = 4;
            this.RemoveEmployeeButton.UseVisualStyleBackColor = true;
            this.RemoveEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
            this.RemoveEmployeeButton.MouseEnter += new System.EventHandler(this.RemoveEmployeeButton_MouseEnter);
            this.RemoveEmployeeButton.MouseLeave += new System.EventHandler(this.RemoveEmployeeButton_MouseLeave);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddEmployeeButton.FlatAppearance.BorderSize = 0;
            this.AddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeButton.Image = global::ListOfEmployees.Properties.Resources.plus_24x24_uncolor;
            this.AddEmployeeButton.Location = new System.Drawing.Point(8, 393);
            this.AddEmployeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(35, 32);
            this.AddEmployeeButton.TabIndex = 2;
            this.AddEmployeeButton.Text = "\r\n";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            this.AddEmployeeButton.MouseEnter += new System.EventHandler(this.AddEmployeeButton_MouseEnter);
            this.AddEmployeeButton.MouseLeave += new System.EventHandler(this.AddEmployeeButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 432);
            this.Controls.Add(this.RemoveEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.SelectedEmployeeGroupBox);
            this.Controls.Add(this.EmployeesListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Employees";
            this.SelectedEmployeeGroupBox.ResumeLayout(false);
            this.SelectedEmployeeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeesListBox;
        private System.Windows.Forms.GroupBox SelectedEmployeeGroupBox;
        private System.Windows.Forms.TextBox PostTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label PostLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button RemoveEmployeeButton;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
    }
}
