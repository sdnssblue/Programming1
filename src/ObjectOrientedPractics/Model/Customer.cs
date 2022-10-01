using ObjectOrientedPractics.Services;

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
        private string _address;

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
        public static int AllCustomersCount
        {
            get => _allCustomersCount;
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
        /// Возвращает и создает адрес покупателя. Адрес должен занимать не более 500 символов.
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Address), value, InitialConstants.MaxLengthAddress);
                _address = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя покупателя. Не более 200 символов.</param>
        /// <param name="address">Адрес покупателя. Не более 500 символов.</param>
        public Customer(string fullname, string address)
        {
            FullName = fullname;
            Address = address;
            _allCustomersCount++;
            _id = _allCustomersCount;
        }
    }
}
