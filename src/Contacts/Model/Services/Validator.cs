using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace View.Model.Services
{
    /// <summary>
    /// Представляет реализацию валидатора.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Валидация имени.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <returns>Возвращает результат валидации <see cref="ValidationResult"/>.</returns>
        public static ValidationResult ValidateName(string name)
        {
            if (name.Length is > 0 and <= 100)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("The name is entered incorrectly.");
        }

        /// <summary>
        /// Валидация номера телефона.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <returns>Возвращает результат валидации <see cref="ValidationResult"/>.</returns>
        public static ValidationResult ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$";
            if (Regex.IsMatch(phoneNumber, pattern))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("The phone number is entered incorrectly.");
        }

        /// <summary>
        /// Валидация адреса электронной почты.
        /// </summary>
        /// <param name="email">Электронная почта.</param>
        /// <returns>Возвращает результат валидации <see cref="ValidationResult"/>.</returns>
        public static ValidationResult ValidateEmail(string email)
        {
            string pattern = @"^\w+\@{1}\w+\.{1}\w+";
            if (Regex.IsMatch(email, pattern))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("The email is entered incorrectly.");
        }
    }
}
