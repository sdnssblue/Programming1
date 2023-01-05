using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;
using System.ComponentModel;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Коллекция заказов.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Текущий заказ.
        /// </summary>
        private Order _currentOrder;

        private PriorityOrder _currentPriorityOrder;

        private string[] _deliveryTime =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        /// <summary>
        /// Создает экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();

            _orders = new List<Order>();

            AddressControl.ReadOnly = true;
            var orderStatusValues = Enum.GetValues(typeof(OrderStatus));
            foreach (var value in orderStatusValues)
            {
                StatusComboBox.Items.Add(value);
            }
            foreach (var time in _deliveryTime)
            {
                DeliveryTimeComboBox.Items.Add(time);
            }

            StatusComboBox.Enabled = false;
            PriorityOptionsPanel.Visible = false;
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
                    UpdateOrders();
                }
            }
        }

        /// <summary>
        /// Обновляет данные в таблице заказов.
        /// </summary>
        private void UpdateOrders()
        {
            foreach (var customer in _customers)
            {
                Address address = customer.Address;
                string fullAddress = $"{address.Index}, {address.Country}, {address.City}," +
                                     $" {address.Street}, {address.Building}, {address.Apartment}";

                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                    OrdersDataGridView.Rows.Add(order.Id.ToString(), order.DateOfCreate,
                        order.Status, customer.FullName, fullAddress, order.Amount.ToString());
                }
            }
        }

        /// <summary>
        /// Обновляет данные вкладки при переходе на нее.
        /// </summary>
        public void RefreshData()
        {
            OrdersDataGridView.Rows.Clear();
            _orders = new List<Order>();
            UpdateOrders();
        }

        private void SetValueInTextBoxes()
        {
            StatusComboBox.Enabled = true;
            IDTextBox.Text = _currentOrder.Id.ToString();
            CreatedTextBox.Text = _currentOrder.DateOfCreate;
            StatusComboBox.SelectedIndex = (int)_currentOrder.Status;
            AddressControl.Address = _currentOrder.Address;

            OrderItemsListBox.Items.Clear();
            foreach (var item in _currentOrder.Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }

            AmountDigitLabel.Text = _currentOrder.Amount.ToString();

            if (_currentOrder is PriorityOrder priority)
            {
                DeliveryTimeComboBox.SelectedIndex = Array.IndexOf(_deliveryTime, _currentPriorityOrder.DeliveryTime);
            }
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int index = OrdersDataGridView.CurrentCell.RowIndex;
            if (index == -1) return;

            _currentOrder = _orders[index];
            if (_currentOrder is PriorityOrder priority)
            {
                _currentPriorityOrder = (PriorityOrder)_orders[index];
                PriorityOptionsPanel.Visible = true;
            }
            else
            {
                PriorityOptionsPanel.Visible = false;
                _currentPriorityOrder = null;
            }
            _currentOrder = _orders[index];
            SetValueInTextBoxes();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = OrdersDataGridView.CurrentCell.RowIndex;

            _currentOrder.Status = (OrderStatus)StatusComboBox.SelectedIndex;
            OrdersDataGridView.Rows[index].Cells[2].Value = (OrderStatus)StatusComboBox.SelectedIndex;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPriorityOrder.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
        }
    }
}