using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
{
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly string _dateOfCreate;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Общая стоимость заказа.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Количество всех заказов.
        /// </summary>
        private static int _allOrdersCount;

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>. 
        /// </summary>
        public Order()
        {
            _allOrdersCount++;
            _id = _allOrdersCount;
            _dateOfCreate = DateTime.Today.ToString();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>. 
        /// </summary>
        /// <param name="status">Статус заказа.</param>
        /// <param name="address">Адрес.</param>
        /// <param name="items">Товары.</param>
        public Order(OrderStatus status, Address address, List<Item> items)
        {
            Status = status;
            Address = address;
            Items = items;
            _allOrdersCount++;
            _id = _allOrdersCount;
            _dateOfCreate = DateTime.Today.ToString();
        }

        /// <summary>
        /// Возвращает итоговую стоимость заказа.
        /// </summary>
        public double Total
        {
            get => Amount - DiscountAmount;
        }

        /// <summary>
        /// Возвращает и задает уникальный индефикатор.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public string DateOfCreate
        {
            get => _dateOfCreate;
        }

        /// <summary>
        /// Возвращает и задает количество всех заказов.
        /// </summary>
        public static int AllOrdersCount
        {
            get => _allOrdersCount;
        }

        /// <summary>
        /// Возвращает и задает адрес доставки для покупателя.
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает коллекцию товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает и задает общую стоимость товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                _amount = 0.00;

                if (_items == null)
                {
                    return _amount;
                }

                foreach (var item in Items)
                {
                    _amount += item.Cost;
                }
                return _amount;

            }
        }

        /// <summary>
        /// Возвращает и задает скидку на товары.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Возвращает и задает состояние заказа.
        /// </summary>
        public OrderStatus Status { get; set; }
    }
}
