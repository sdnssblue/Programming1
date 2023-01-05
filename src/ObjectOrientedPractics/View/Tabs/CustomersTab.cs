using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using System.ComponentModel;
using ObjectOrientedPractics.View.Forms;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Реализация по представлению покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Коллекция пользователей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Выбранный пользователь.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            _customers = new List<Customer>();
            IsPriorityCheckBox.Enabled = false;
        }

        /// <summary>
        /// Возвращает и задает коллекцию покупателей.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;

                if (_customers != null)
                {
                    UpdateCustomerInfo(-1);
                }
            }
        }

        /// <summary>
        /// Очищает информацию с текстовых полей.
        /// </summary>
        private void ClearCustomersInfo()
        {
            IDTextBox.Clear();
            FullNameTextBox.Clear();
            AddressControl.Clear();
            DiscountsListBox.Items.Clear();
            IsPriorityCheckBox.Checked = false;
        }

        private void UpdateDiscountsListBox()
        {
            DiscountsListBox.Items.Clear();

            foreach (var discount in _currentCustomer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="selectedIndex">Выбранный индекс.</param>
        private void UpdateCustomerInfo(int selectedIndex)
        {
            CustomersListBox.Items.Clear();

            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add(FormattedText(customer));
            }

            if (selectedIndex == -1) AddressControl.Enabled = false;
            CustomersListBox.SelectedIndex = selectedIndex;
        }

        private string FormattedText(Customer customer)
        {
            return $"{customer.Id}: " + $"{customer.FullName};";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerFactory.DefaultCustomer();
            _currentCustomer = customer;
            CustomersListBox.Items.Add(FormattedText(_currentCustomer));
            _customers.Add(customer);
            UpdateCustomerInfo(0);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index == -1) return;

            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);
            UpdateCustomerInfo(-1);
            ClearCustomersInfo();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                int index = CustomersListBox.SelectedIndex;

                if (index == -1)
                {
                    AddressControl.Enabled = false;
                    IsPriorityCheckBox.Enabled = false;
                    return;
                }

                AddressControl.Enabled = true;
                IsPriorityCheckBox.Enabled = true;

                _currentCustomer = _customers[index];

                IsPriorityCheckBox.Checked = _currentCustomer.IsPriority;
                IDTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                AddressControl.Address = _currentCustomer.Address;
                UpdateDiscountsListBox();
            }

        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                string customerCurrentFullName = FullNameTextBox.Text;
                _currentCustomer.FullName = customerCurrentFullName;
                int index = _customers.IndexOf(_currentCustomer);
                UpdateCustomerInfo(index);
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            FullNameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _currentCustomer.IsPriority = IsPriorityCheckBox.Checked;
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            AddDiscountForm addDiscountForm = new AddDiscountForm();
            if (addDiscountForm.ShowDialog() == DialogResult.OK)
            {
                foreach (var discount in _currentCustomer.Discounts)
                {
                    if (discount is PointsDiscount) continue;
                    if (((PercentDiscount)discount).Category ==
                        addDiscountForm.PercentDiscount.Category) return;
                }
                _currentCustomer.Discounts.Add(addDiscountForm.PercentDiscount);
                UpdateDiscountsListBox();
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            int index = DiscountsListBox.SelectedIndex;
            if (index == -1) return;
            if (index == 0) return;
            _currentCustomer.Discounts.RemoveAt(index);
            UpdateDiscountsListBox();
        }
    }
}