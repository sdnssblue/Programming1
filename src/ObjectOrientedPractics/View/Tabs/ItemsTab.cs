using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Реализация по представлению товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            var category = Enum.GetValues(typeof(Category));

            foreach (var value in category)
            {
                CategoryComboBox.Items.Add(value);
            }
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
                    UpdateItemInfo(-1);
                }
            }
        }

        /// <summary>
        /// Очищает информацию с текстовых полей.
        /// </summary>
        private void ClearItemsInfo()
        {
            IDTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="selectedIndex">Выбранный индекс.</param>
        private void UpdateItemInfo(int selectedIndex)
        {
            ItemsListBox.Items.Clear();

            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add($"{item.Id}: " + $"{item.Name};");
            }

            if (selectedIndex == -1) return;

            ItemsListBox.SelectedIndex = selectedIndex;
        }

        private string FormattedText(Item item)
        {
            return $"{item.Id}: " + $"{item.Name};";
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            Item item = ItemFactory.DefaultItem();
            _currentItem = item;
            ItemsListBox.Items.Add(FormattedText(_currentItem));
            _items.Add(item);
        }

        private void RemoveButton_Click(object sender, System.EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            _items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);

            ClearItemsInfo();
        }

        private void ListBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                int indexSelectedItem = ItemsListBox.SelectedIndex;
                _currentItem = _items[indexSelectedItem];
                IDTextBox.Text = _currentItem.Id.ToString();
                CostTextBox.Text = _currentItem.Cost.ToString();
                NameTextBox.Text = _currentItem.Name;
                DescriptionTextBox.Text = _currentItem.Info;
                CategoryComboBox.SelectedItem = _currentItem.Category;
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
                return;
            try
            {
                string itemCurrentCost = CostTextBox.Text;
                int itemCost = int.Parse(itemCurrentCost);
                _currentItem.Cost = itemCost;
                int index = _items.IndexOf(_currentItem);
                UpdateItemInfo(index);
            }
            catch
            {
                CostTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            CostTextBox.BackColor = AppColors.CorrectColor;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
                return;
            try
            {
                string itemCurrentName = NameTextBox.Text;
                _currentItem.Name = itemCurrentName;
                int index = _items.IndexOf(_currentItem);
                UpdateItemInfo(index);
            }
            catch
            {
                NameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            NameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
                return;
            try
            {
                string itemCurrentDescription = DescriptionTextBox.Text;
                _currentItem.Info = itemCurrentDescription;
                int index = _items.IndexOf(_currentItem);
                UpdateItemInfo(index);
            }
            catch
            {
                DescriptionTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            DescriptionTextBox.BackColor = AppColors.CorrectColor;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox == null) return;

            _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
            int index = _items.IndexOf(_currentItem);
            UpdateItemInfo(index);
        }
    }
}
