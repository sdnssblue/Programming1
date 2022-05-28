﻿using System;
using Programming.Model.Geometry;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model;

namespace Programming.View.Controls
{
    public partial class RectanglesCollisionControl : UserControl
    {

        private List<Rectangle> _rectangles;

        private List<Panel> _rectanglePanels;

        private Rectangle _currentRectangle;

        public RectanglesCollisionControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
        }

        private string RectangleParameters(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X: {rectangle.Center.X};" +
                   $" Y: {rectangle.Center.Y};" +
                   $" W: {rectangle.Width};" +
                   $" H: {rectangle.Height})";
        }

        private void FindCollisions()
        {
            for (int k = 0; k < _rectangles.Count; k++)
            {
                CanvasPanel.Controls[k].BackColor = AppColors.UnContact;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = AppColors.InContact;
                        CanvasPanel.Controls[j].BackColor = AppColors.InContact;
                    }
                }
            }
        }

        private void ClearRectangleInfo()
        {
            RectanglesListBox.Items.Clear();
            //RectangleListBox.Items.Clear();

            RectangleSelectedIdTextBox.Clear();
            RectangleSelectedXTextBox.Clear();
            RectangleSelectedYTextBox.Clear();
            RectangleSelectedWidthTextBox.Clear();
            RectangleSelectedHeightTextBox.Clear();

            //RectangleWidthTextBox.Clear();
            //RectangleHeightTextBox.Clear();
            //RectangleColorTextBox.Clear();
            //RectangleIdTextBox.Clear();
            //RectangleXTextBox.Clear();
            //RectangleYTextBox.Clear();
        }

        private Panel InitPanel()
        {
            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = _currentRectangle.Width;
            rectanglePanel.Height = _currentRectangle.Height;
            rectanglePanel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            rectanglePanel.BackColor = AppColors.UnContact;

            return rectanglePanel;
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = RectanglesListBox.FindString(rectangle.Id.ToString());

            if (index == -1) return;

            RectanglesListBox.Items[index] = RectangleParameters(rectangle);
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
            //RectangleListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
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
                //RectangleListBox.Items.Add($"Rectangle {rectangle.Id}");
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
                RectangleSelectedXTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            RectangleSelectedXTextBox.BackColor = AppColors.CorrectColor;
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
                RectangleSelectedYTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            RectangleSelectedYTextBox.BackColor = AppColors.CorrectColor;
        }

        private void RectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string currentWidthRectangle = RectangleSelectedWidthTextBox.Text;
                int widthRectangleValue = int.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangleValue;
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Width = _currentRectangle.Width;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                RectangleSelectedWidthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            RectangleSelectedWidthTextBox.BackColor = AppColors.CorrectColor;
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
                RectangleSelectedHeightTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            RectangleSelectedHeightTextBox.BackColor = AppColors.CorrectColor;
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
