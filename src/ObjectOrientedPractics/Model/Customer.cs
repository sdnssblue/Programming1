using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        private static int _allCustomersCount;

        private readonly int _id;

        private string _fullname;

        private string _address;

        public int Id
        {
            get => _id;
        }

        public static int AllCustomersCount
        {
            get => _allCustomersCount;
        }

        public string Fullname
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Fullname), value, InitialConstants.MaxLengthFullName);
                _fullname = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Address), value, InitialConstants.MaxLengthAddress);
                _address = value;
            }
        }

        public Customer()
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
        }

        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _allCustomersCount++;
            _id = _allCustomersCount;
        }
    }
}
