using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные об адресе.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Название страны/региона.
        /// </summary>
        private string _country;

        /// <summary>
        /// Название города/населенного пункта.
        /// </summary>
        private string _city;

        /// <summary>
        /// Название улицы.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс.
        /// Почтовый индекс должен являться целым шестизначным числом.
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                ValueValidator.AssertStringLength(nameof(Index), value, InitialConstants.NumberOfDigitsInIndex);
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и создает название страны/региона.
        /// Название страны/города должно занимать не более 50 символов.
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Country), value, InitialConstants.MaxLengthCountry);
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и создает название города/населенного пункта.
        /// Название города/населенного пункта должно занимать не более 50 символов.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(City), value, InitialConstants.MaxLengthCity);
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и создает название улицы.
        /// Название улицы должно занимать не более 100 символов.
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Street), value, InitialConstants.MaxLengthStreet);
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и создает номер дома.
        /// Номер дома должен занимать не более 10 символов.
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Building), value, InitialConstants.MaxLengthBuilding);
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и создает номер квартиры/помещения.
        /// Номер квартиры/помещения должен занимать не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Apartment), value, InitialConstants.MaxLengthApartment);
                _apartment = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>
        /// </summary>
        /// <param name="index">Почтовый индекс. Целое шестизначное число.</param>
        /// <param name="country">Страна/регион. Не более 50 символов.</param>
        /// <param name="city">Город/населенный пункт. Не более 50 символов.</param>
        /// <param name="street">Название улицы. Не более 100 символов.</param>
        /// <param name="building">Номер дома. Не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения. Не более 10 символов.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
