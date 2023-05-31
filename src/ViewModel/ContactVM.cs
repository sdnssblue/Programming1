using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System;
using Model;

namespace ViewModel
{
    /// <summary>
    /// ViewModel, агрегирующий в себе класс <see cref="Model.Contact"/>
    /// </summary>
    public class ContactVM : ObservableValidator, ICloneable
    {
        /// <summary>
        /// Возвращает и получает объект класса <see cref="Model.Contact"/>
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Возращает и получает имя объекта.
        /// </summary>
        [MaxLength(100)]
        [Required(AllowEmptyStrings = false)]
        public string Name
        {
            get => Contact.Name;
            set => SetProperty(Contact.Name, value, Contact, (contact, name) => Contact.Name = name, true);
        }

        /// <summary>
        /// Возращает и получает номер объекта.
        /// </summary>
        [MinLength(11)]
        [MaxLength(18)]
        [Required(AllowEmptyStrings = false)]
        [Phone(ErrorMessage = "Phone Number can contains only digits and symbols '+()-'. Example: +7 (999) 999-99-99")]
        public string PhoneNumber
        {
            get => Contact.PhoneNumber;
            set => SetProperty(Contact.PhoneNumber, value, Contact, (contact, phone) => Contact.PhoneNumber = phone, true);
        }

        /// <summary>
        /// Возращает и получает почту объекта.
        /// </summary>
        [EmailAddress]
        [MaxLength(100)]
        [Required(AllowEmptyStrings = false)]
        public string Email
        {
            get => Contact.Email;
            set => SetProperty(Contact.Email, value, Contact, (contact, email) => Contact.Email = email, true);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="contact">Объект класса <see cref="Model.Contact"/>.</param>
        public ContactVM(Contact contact)
        {
            Contact = contact;
        }

        /// <summary>
        /// Создает копию объекта.
        /// </summary>
        /// <returns>Объект класса <see cref="ContactVM"/>.</returns>
        public object Clone()
        {
            return new ContactVM((Contact)Contact.Clone());
        }
    }
}