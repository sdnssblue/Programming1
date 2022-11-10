using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверка на то, что значение типа double находится в диапозоне от одного числа до другого.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="minValueCost">Левая граница диапазона (минимальное значение).</param>
        /// <param name="maxValueCost">Правая граница диапазона (максимальное значение).</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(string nameProperty, double value, double minValueCost, double maxValueCost)
        {
            if (value < minValueCost || value > maxValueCost)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should be between {minValueCost} and {maxValueCost} (inclusive).");
            }
        }

        /// <summary>
        /// Проверка на то, что строка по длине не больше, чем максимальная возможная длина.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="maxLength">Максимальная длина.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertStringOnLength(string nameProperty, string value, int maxLength)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(
                    $"number of characters in the field {nameProperty} must be less than {maxLength}.");
            }
        }

        /// <summary>
        /// Проверка на то, что количество цифр в числе совпадает с нужным количеством.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="length">Заданная длина.</param>
        /// <param name="value">Число.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда количество цифр числа не равно заданному.</exception>
        public static void AssertStringLength(string nameProperty, int value, int length)
        {
            if (value.ToString().Length != length)
            {
                throw new ArgumentException(
                    $"the number of digits in {nameProperty} must be equal to {length}.");
            }
        }
    }
}