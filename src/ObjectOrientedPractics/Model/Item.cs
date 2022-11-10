using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товарах.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Количество всех товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Цена товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задает уникальный индефикатор.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Возвращает и задает количество всех покупателей.
        /// </summary>
        public static int AllItemsCount
        {
            get => _allItemsCount;
        }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает название товара. 
        /// Название товара должно занимать не более 200 символов.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Name), value, InitialConstants.MaxLengthName);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и создает описание товара.
        /// Описание должно занимать не более 1000 символов.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Info), value, InitialConstants.MaxLengthInfo);
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и создает цену товара.
        /// Цена товара должна быть значением от 0 до 100000.
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertValueInRange(nameof(Cost), value, InitialConstants.MinValueCost, InitialConstants.MaxValueCost);
                _cost = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        public Item()
        {
            _allItemsCount++;
            _id = _allItemsCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="name">Название товара. Не более 200 символов.</param>
        /// <param name="info">Описание товара. Не более 1000 символов.</param>
        /// <param name="cost">Цена товара. Значение должно быть числом от 0 до 100000.</param>
        /// /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            _allItemsCount++;
            _id = _allItemsCount;
        }
    }
}
