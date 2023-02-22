using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;
using System.ComponentModel;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Создает экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задает коллекцию товаров.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;

                if (_items != null)
                {
                    UpdateItemsListBox(-1);
                }
            }
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
                    foreach (var customer in _customers)
                    {
                        CustomerComboBox.Items.Add(customer.FullName);
                    }
                }
            }
        }

        /// <summary>
        /// Возвращает и задает выбранного покупателя.
        /// </summary>
        private Customer CurrentCustomer { get; set; }

        private void UpdateDiscountDigit()
        {
            double discountAmount = 0;
            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    discountAmount += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                }
            }
            DiscountAmountDigitLabel.Text = discountAmount.ToString();
            if (CurrentCustomer.Cart.Amount == 0)
            {
                TotalDigitLabel.Text = CurrentCustomer.Cart.Amount.ToString();
                return;
            }
            TotalDigitLabel.Text = (CurrentCustomer.Cart.Amount - discountAmount).ToString();
        }

        /// <summary>
        /// Обновляет данные в списках.
        /// </summary>
        public void RefreshData()
        {
            UpdateItemsListBox(-1);

            CustomerComboBox.Items.Clear();
            foreach (var customer in _customers)
            {
                CustomerComboBox.Items.Add(customer.FullName);
            }

            if (CustomerComboBox.Items.Count > 0)
            {
                CustomerComboBox.SelectedIndex = 0;
            }
            else
            {
                CustomerComboBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Сортирует и обновляет данные в списке с товарами.
        /// </summary>
        /// <param name="selectedIndex">Индекс выбранного элемента.</param>
        private void UpdateItemsListBox(int selectedIndex)
        {
            ItemsListBox.Items.Clear();

            var orderedListItems = from item in _items
                                   orderby item.Name
                                   select item;

            _items = orderedListItems.ToList();

            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add(FormattedText(item));
            }

            ItemsListBox.SelectedIndex = selectedIndex;
        }

        private void UpdateDiscountCheckedListBox()
        {
            DiscountCheckedListBox.Items.Clear();
            foreach (var discount in CurrentCustomer.Discounts)
            {
                DiscountCheckedListBox.Items.Add(discount.Info, true);
            }
        }

        /// <summary>
        /// Сортирует и обновляет данные в списке с корзиной.
        /// </summary>
        /// <param name="selectedIndex">Индекс выбранного элемента.</param>
        private void UpdateCartListBox(int selectedIndex)
        {
            CartListBox.Items.Clear();

            var orderedListItems = from item in CurrentCustomer.Cart.Items
                                   orderby item.Name
                                   select item;

            CurrentCustomer.Cart.Items = orderedListItems.ToList();

            foreach (Item item in CurrentCustomer.Cart.Items)
            {
                CartListBox.Items.Add(FormattedText(item));
            }

            CartListBox.SelectedIndex = selectedIndex;
            CreateOrderButton.Enabled = false;
        }

        private string FormattedText(Item item)
        {
            return $"{item.Name}";
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomerComboBox.SelectedIndex;

            if (index == -1) return;

            CurrentCustomer = _customers[index];

            if (CurrentCustomer.Cart.Items == null) return;

            AmountDigitLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            UpdateCartListBox(-1);
            UpdateDiscountCheckedListBox();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            int indexListBox = ItemsListBox.SelectedIndex;
            int indexComboBox = CustomerComboBox.SelectedIndex;

            if (indexListBox == -1 || indexComboBox == -1) return;

            CurrentCustomer.Cart.Items.Add(_items[indexListBox]);

            AmountDigitLabel.Text = CurrentCustomer.Cart.Amount.ToString();

            UpdateCartListBox(-1);
            CreateOrderButton.Enabled = true;
            UpdateDiscountDigit();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int indexComboBox = CustomerComboBox.SelectedIndex;
            int indexListBox = CartListBox.SelectedIndex;

            if (indexListBox == -1 || indexComboBox == -1) return;

            CurrentCustomer.Cart.Items.RemoveAt(indexListBox);
            AmountDigitLabel.Text = CurrentCustomer.Cart.Amount.ToString();

            UpdateCartListBox(-1);
            UpdateDiscountDigit();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null) return;

            CurrentCustomer.Cart = new Cart();
            UpdateCartListBox(-1);
            AmountDigitLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            UpdateDiscountDigit();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Order order;
            if (CurrentCustomer.IsPriority)
            {
                order = new PriorityOrder();
            }
            else
            {
                order = new Order();
            }

            order.Address = CurrentCustomer.Address;
            order.Items = CurrentCustomer.Cart.Items;
            order.Status = OrderStatus.New;
            double discountAmount = 0;
            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    discountAmount += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                }
            }
            order.DiscountAmount = discountAmount;
            CurrentCustomer.Orders.Add(order);

            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    CurrentCustomer.Discounts[i].Apply(CurrentCustomer.Cart.Items);
                }
                CurrentCustomer.Discounts[i].Update(CurrentCustomer.Cart.Items);
            }
            UpdateDiscountCheckedListBox();

            CurrentCustomer.Cart = new Cart();
            UpdateCartListBox(-1);
            AmountDigitLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            CreateOrderButton.Enabled = false;
        }

        private void DiscountCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscountDigit();
        }
    }
}
