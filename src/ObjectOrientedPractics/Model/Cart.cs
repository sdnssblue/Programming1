using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет реализацию корзины товаров.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Общая стоимость товаров в корзине.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
            _amount = 0.00;
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
    }
}
