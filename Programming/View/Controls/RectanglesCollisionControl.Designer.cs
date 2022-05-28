
namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.RemoveSelectedRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.RectangleSelectedHeightTextBox = new System.Windows.Forms.TextBox();
            this.RectangleSelectedHeightLabel = new System.Windows.Forms.Label();
            this.RectangleSelectedWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleSelectedWidthLabel = new System.Windows.Forms.Label();
            this.RectangleSelectedYTextBox = new System.Windows.Forms.TextBox();
            this.RectangleSelectedYLabel = new System.Windows.Forms.Label();
            this.RectangleSelectedXTextBox = new System.Windows.Forms.TextBox();
            this.RectangleSelectedXLabel = new System.Windows.Forms.Label();
            this.RectangleSelectedIdLabel = new System.Windows.Forms.Label();
            this.RectangleSelectedIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.TabControl.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.RectanglesTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(690, 471);
            this.TabControl.TabIndex = 1;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.RemoveSelectedRectangleButton);
            this.RectanglesTabPage.Controls.Add(this.AddRectangleButton);
            this.RectanglesTabPage.Controls.Add(this.RectangleSelectedHeightTextBox);
            this.RectanglesTabPage.Controls.Add(this.RectangleSelectedHeightLabel);
            this.RectanglesTabPage.Controls.Add(this.RectangleSelectedWidthTextBox);
            this.RectanglesTabPage.Controls.Add(this.RectangleSelectedWidthLabel);
            this.RectanglesTabPage.Controls.Add(this.RectangleSelectedYTextBox);
            this.RectanglesTabPage.Controls.Add(this.RectangleSelectedYLabel);
            this.RectanglesTabPage.Controls.Add(this.RectangleSelectedXTextBox);
            this.RectanglesTabPage.Controls.Add(this.RectangleSelectedXLabel);
            this.RectanglesTabPage.Controls.Add(this.RectangleSelectedIdLabel);
            this.RectanglesTabPage.Controls.Add(this.RectangleSelectedIdTextBox);
            this.RectanglesTabPage.Controls.Add(this.SelectedRectangleLabel);
            this.RectanglesTabPage.Controls.Add(this.CanvasPanel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesListBox);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(682, 445);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // RemoveSelectedRectangleButton
            // 
            this.RemoveSelectedRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveSelectedRectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.RemoveSelectedRectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveSelectedRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedRectangleButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveSelectedRectangleButton.Location = new System.Drawing.Point(206, 139);
            this.RemoveSelectedRectangleButton.Name = "RemoveSelectedRectangleButton";
            this.RemoveSelectedRectangleButton.Size = new System.Drawing.Size(75, 26);
            this.RemoveSelectedRectangleButton.TabIndex = 15;
            this.RemoveSelectedRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedRectangleButton.Click += new System.EventHandler(this.RemoveButton_Click);
            this.RemoveSelectedRectangleButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.RemoveSelectedRectangleButton.MouseLeave += new System.EventHandler(this.RemoveButton_MouseLeave);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.AddRectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectangleButton.Location = new System.Drawing.Point(12, 139);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(75, 26);
            this.AddRectangleButton.TabIndex = 14;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // RectangleSelectedHeightTextBox
            // 
            this.RectangleSelectedHeightTextBox.Location = new System.Drawing.Point(55, 302);
            this.RectangleSelectedHeightTextBox.Name = "RectangleSelectedHeightTextBox";
            this.RectangleSelectedHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleSelectedHeightTextBox.TabIndex = 13;
            this.RectangleSelectedHeightTextBox.TextChanged += new System.EventHandler(this.RectanglesWidthTextBox_TextChanged);
            // 
            // RectangleSelectedHeightLabel
            // 
            this.RectangleSelectedHeightLabel.AutoSize = true;
            this.RectangleSelectedHeightLabel.Location = new System.Drawing.Point(12, 305);
            this.RectangleSelectedHeightLabel.Name = "RectangleSelectedHeightLabel";
            this.RectangleSelectedHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.RectangleSelectedHeightLabel.TabIndex = 12;
            this.RectangleSelectedHeightLabel.Text = "Height:";
            // 
            // RectangleSelectedWidthTextBox
            // 
            this.RectangleSelectedWidthTextBox.Location = new System.Drawing.Point(55, 276);
            this.RectangleSelectedWidthTextBox.Name = "RectangleSelectedWidthTextBox";
            this.RectangleSelectedWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleSelectedWidthTextBox.TabIndex = 11;
            this.RectangleSelectedWidthTextBox.TextChanged += new System.EventHandler(this.RectanglesWidthTextBox_TextChanged);
            // 
            // RectangleSelectedWidthLabel
            // 
            this.RectangleSelectedWidthLabel.AutoSize = true;
            this.RectangleSelectedWidthLabel.Location = new System.Drawing.Point(12, 279);
            this.RectangleSelectedWidthLabel.Name = "RectangleSelectedWidthLabel";
            this.RectangleSelectedWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.RectangleSelectedWidthLabel.TabIndex = 10;
            this.RectangleSelectedWidthLabel.Text = "Width:";
            // 
            // RectangleSelectedYTextBox
            // 
            this.RectangleSelectedYTextBox.Location = new System.Drawing.Point(55, 250);
            this.RectangleSelectedYTextBox.Name = "RectangleSelectedYTextBox";
            this.RectangleSelectedYTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleSelectedYTextBox.TabIndex = 9;
            this.RectangleSelectedYTextBox.TextChanged += new System.EventHandler(this.RectanglesYTextBox_TextChanged);
            // 
            // RectangleSelectedYLabel
            // 
            this.RectangleSelectedYLabel.AutoSize = true;
            this.RectangleSelectedYLabel.Location = new System.Drawing.Point(35, 253);
            this.RectangleSelectedYLabel.Name = "RectangleSelectedYLabel";
            this.RectangleSelectedYLabel.Size = new System.Drawing.Size(17, 13);
            this.RectangleSelectedYLabel.TabIndex = 8;
            this.RectangleSelectedYLabel.Text = "Y:";
            // 
            // RectangleSelectedXTextBox
            // 
            this.RectangleSelectedXTextBox.Location = new System.Drawing.Point(55, 224);
            this.RectangleSelectedXTextBox.Name = "RectangleSelectedXTextBox";
            this.RectangleSelectedXTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleSelectedXTextBox.TabIndex = 7;
            this.RectangleSelectedXTextBox.TextChanged += new System.EventHandler(this.RectanglesXTextBox_TextChanged);
            // 
            // RectangleSelectedXLabel
            // 
            this.RectangleSelectedXLabel.AutoSize = true;
            this.RectangleSelectedXLabel.Location = new System.Drawing.Point(35, 227);
            this.RectangleSelectedXLabel.Name = "RectangleSelectedXLabel";
            this.RectangleSelectedXLabel.Size = new System.Drawing.Size(17, 13);
            this.RectangleSelectedXLabel.TabIndex = 6;
            this.RectangleSelectedXLabel.Text = "X:";
            // 
            // RectangleSelectedIdLabel
            // 
            this.RectangleSelectedIdLabel.AutoSize = true;
            this.RectangleSelectedIdLabel.Location = new System.Drawing.Point(35, 201);
            this.RectangleSelectedIdLabel.Name = "RectangleSelectedIdLabel";
            this.RectangleSelectedIdLabel.Size = new System.Drawing.Size(19, 13);
            this.RectangleSelectedIdLabel.TabIndex = 5;
            this.RectangleSelectedIdLabel.Text = "Id:";
            // 
            // RectangleSelectedIdTextBox
            // 
            this.RectangleSelectedIdTextBox.Enabled = false;
            this.RectangleSelectedIdTextBox.Location = new System.Drawing.Point(55, 198);
            this.RectangleSelectedIdTextBox.Name = "RectangleSelectedIdTextBox";
            this.RectangleSelectedIdTextBox.ReadOnly = true;
            this.RectangleSelectedIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleSelectedIdTextBox.TabIndex = 4;
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(12, 182);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(104, 13);
            this.SelectedRectangleLabel.TabIndex = 3;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(303, 25);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(366, 400);
            this.CanvasPanel.TabIndex = 2;
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(12, 6);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesLabel.TabIndex = 1;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(12, 25);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(269, 108);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(690, 471);
            this.TabControl.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private System.Windows.Forms.Button RemoveSelectedRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.TextBox RectangleSelectedHeightTextBox;
        private System.Windows.Forms.Label RectangleSelectedHeightLabel;
        private System.Windows.Forms.TextBox RectangleSelectedWidthTextBox;
        private System.Windows.Forms.Label RectangleSelectedWidthLabel;
        private System.Windows.Forms.TextBox RectangleSelectedYTextBox;
        private System.Windows.Forms.Label RectangleSelectedYLabel;
        private System.Windows.Forms.TextBox RectangleSelectedXTextBox;
        private System.Windows.Forms.Label RectangleSelectedXLabel;
        private System.Windows.Forms.Label RectangleSelectedIdLabel;
        private System.Windows.Forms.TextBox RectangleSelectedIdTextBox;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
