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
        /// Максимальное количество символов для <see cref="Customer.FullName"/>.
        /// </summary>
        public const int MaxLengthFullName = 200;

        /// <summary>
        /// Максимальное количество символов для <see cref="Customer.Address"/>.
        /// </summary>
        public const int MaxLengthAddress = 500;

        /// <summary>
        /// Минимальное значение для <see cref="Item.Cost"/>
        /// </summary>
        public const double MinValueCost = 0;

        /// <summary>
        /// Максимальное значение для <see cref="Item.Cost"/>
        /// </summary>
        public const double MaxValueCost = 100000;
    }
}