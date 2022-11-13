﻿using ObjectOrientedPractics.Services;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателях.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Количество всех покупателей.
        /// </summary>
        private static int _allCustomersCount;

        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина товаров покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Коллекция заказов.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Возвращает и задает количество всех покупателей.
        /// </summary>
        public static int AllCustomersCount
        {
            get => _allCustomersCount;
        }

        /// <summary>
        /// Возвращает и задает уникальный индефикатор.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Возвращает и задает полное имя покупателя. Полное имя должно занимать не более 200 символов.
        /// </summary>
        public string FullName
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(FullName), value, InitialConstants.MaxLengthFullName);
                _fullname = value;
            }
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
        /// Возвращает и задает корзину товаров покупателя.
        /// </summary>
        public Cart Cart
        {
            get => _cart;
            set
            {
                _cart = value;
            }
        }

        /// <summary>
        /// Возвращает и задает коллекцию заказов.
        /// </summary>
        public List<Order> Orders
        {
            get => _orders;
            set
            {
                _orders = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
            Cart = new Cart();
            Orders = new List<Order>();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя покупателя. Не более 200 символов.</param>
        /// <param name="address">Aдрес доставки для покупателя.</param>
        public Customer(string fullname, Address address, Cart cart, List<Order> orders)
        {
            FullName = fullname;
            Address = address;
            Cart = cart;
            Orders = orders;
            _allCustomersCount++;
            _id = _allCustomersCount;
        }
    }
}
