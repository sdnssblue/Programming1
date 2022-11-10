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
        private Address _address;

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
        /// <param name="address">Aдрес доставки для покупателя.</param>
        public Customer(string fullname, Address address)
        {
            FullName = fullname;
            Address = address;
            _allCustomersCount++;
            _id = _allCustomersCount;
        }
    }
}
