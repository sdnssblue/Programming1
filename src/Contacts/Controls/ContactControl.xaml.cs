using Model;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace View.Controls
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Регистрирует свойство зависимости для SelectedContact.
        /// </summary>
        public static readonly DependencyProperty SelectedContactProperty =
            DependencyProperty.Register("SelectedContact", typeof(Contact),
            typeof(ContactControl), new UIPropertyMetadata(null));

        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задаёт выбранный контакт.
        /// </summary>
        public Contact SelectedContact
        {
            get => (Contact)GetValue(SelectedContactProperty);
            set => SetValue(SelectedContactProperty, value);
        }

        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string pattern = @"[\+\-\(\)\d]";
            if (!Regex.IsMatch(e.Text, pattern))
            {
                e.Handled = true;
            }
        }

        private void PhoneNumberTextBox_Paste(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string input = (string)e.DataObject.GetData(typeof(string));
                string pattern = @"[\+\-\(\)\d]";
                if (!Regex.IsMatch(input, pattern))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }
    }
}
