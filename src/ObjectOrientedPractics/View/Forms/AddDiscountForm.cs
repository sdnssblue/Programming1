using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        public AddDiscountForm()
        {
            InitializeComponent();
            var categoryValues = Enum.GetValues(typeof(Category));
            foreach (var value in categoryValues)
            {
                CategoryComboBox.Items.Add(value);
            }
            CategoryComboBox.SelectedIndex = 0;
        }

        public PercentDiscount PercentDiscount { get; set; }

        private void OkeyButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == -1)
            {
                return;
            }

            PercentDiscount = new PercentDiscount((Category)CategoryComboBox.SelectedIndex);
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}