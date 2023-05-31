using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.Converters
{
    /// <summary>
    ///  Представляет реализацию для конвертирования bool значений.
    /// </summary>
    public class InverseVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Конвертирует булевое значение в противоположное.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="targetType">Целевой тип.</param>
        /// <param name="parameter">Параметр.</param>
        /// <param name="culture">Региональная культура</param>
        /// <returns>Значение видимости элемента.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool boolValue ? !boolValue : throw new ArgumentException("Value must be bool.");
        }

        /// <summary>
        /// Конвертирует булевое значение в противоположное.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="targetType">Целевой тип.</param>
        /// <param name="parameter">Параметр.</param>
        /// <param name="culture">Региональная культура</param>
        /// <returns>Булевое значение.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool boolValue ? !boolValue : throw new ArgumentException("Value must be bool.");
        }
    }
}