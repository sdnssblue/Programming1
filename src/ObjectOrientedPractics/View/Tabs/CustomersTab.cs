using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Реализация по представлению пользователей.
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

            if (ProjectSerializer.IsFile(nameof(Customer)))
            {
                _customers = ProjectSerializer.Deserialize<Customer>(nameof(Customer));

                foreach (var item in _customers)
                {
                    CustomersListBox.Items.Add(item.FullName);
                }

                CustomersListBox.SelectedIndex = _customers.Count - 1;
            }
        }

        /// <summary>
        /// Очищает информацию с текстовых полей.
        /// </summary>
        private void ClearCustomersInfo()
        {
            IDTextBox.Clear();
            FullNameTextBox.Clear();
            AddressTextBox.Clear();
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
                CustomersListBox.Items.Add($"{customer.Id}: " + $"{customer.FullName};");
            }

            if (selectedIndex == -1) return;

            CustomersListBox.SelectedIndex = selectedIndex;
        }

        private string FormattedText(Customer customer)
        {
            return $"{customer.Id}: " + $"{customer.FullName};";
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            Customer customer = CustomerFactory.DefaultCustomer();
            _currentCustomer = customer;
            CustomersListBox.Items.Add(FormattedText(_currentCustomer));
            _customers.Add(customer);
        }

        private void RemoveButton_Click(object sender, System.EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index == -1) return;

            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            ClearCustomersInfo();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                int indexSelectedCustomer = CustomersListBox.SelectedIndex;
                _currentCustomer = _customers[indexSelectedCustomer];
                IDTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                AddressTextBox.Text = _currentCustomer.Address;
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
                return;
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

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
                return;
            try
            {
                string customerCurrentAddress = AddressTextBox.Text;
                _currentCustomer.Address = customerCurrentAddress;
                int index = _customers.IndexOf(_currentCustomer);
                UpdateCustomerInfo(index);
            }
            catch
            {
                AddressTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            AddressTextBox.BackColor = AppColors.CorrectColor;
        }

        public void SaveCustomersData()
        {
            ProjectSerializer.Serialize(nameof(Customer), _customers);
        }
    }
}