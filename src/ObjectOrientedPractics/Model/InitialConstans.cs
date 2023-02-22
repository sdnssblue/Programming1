namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о константиах.
    /// </summary>
    public static class InitialConstants
    {
        /// <summary>
        /// Максимальное количество символов для <see cref="Item.Name"/>.
        /// </summary>
        public const int MaxLengthName = 200;

        /// <summary>
        /// Максимальное количество символов для <see cref="Item.Info"/>.
        /// </summary>
        public const int MaxLengthInfo = 1000;

        /// <summary>
        /// Минимальное значение для <see cref="Item.Cost"/>
        /// </summary>
        public const double MinValueCost = 0;

        /// <summary>
        /// Максимальное значение для <see cref="Item.Cost"/>
        /// </summary>
        public const double MaxValueCost = 100000;

        /// <summary>
        /// Максимальное количество символов для <see cref="Customer.FullName"/>.
        /// </summary>
        public const int MaxLengthFullName = 200;

        /// <summary>
        /// Максимальное количество символов для <see cref="Customer.Address"/>.
        /// </summary>
        public const int MaxLengthAddress = 500;

        /// <summary>
        /// Количество цифр в поле <see cref="Address.Index"/>.
        /// </summary>
        public const int NumberOfDigitsInIndex = 6;

        /// <summary>
        /// Максимальное количество символов для <see cref="Address.Country"/>.
        /// </summary>
        public const int MaxLengthCountry = 50;

        /// <summary>
        /// Максимальное количество символов для <see cref="Address.City"/>.
        /// </summary>
        public const int MaxLengthCity = 50;

        /// <summary>
        /// Максимальное количество символов для <see cref="Address.Street"/>.
        /// </summary>
        public const int MaxLengthStreet = 100;

        /// <summary>
        /// Максимальное количество символов для <see cref="Address.Building"/>.
        /// </summary>
        public const int MaxLengthBuilding = 10;

        /// <summary>
        /// Максимальное количество символов для <see cref="Address.Apartament"/>.
        /// </summary>
        public const int MaxLengthApartment = 10;
    }
}