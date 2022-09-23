using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {

        private static int _allItemsCount;

        private readonly int _id;

        private string _name;

        private string _info;

        private double _cost;

        public int Id
        {
            get => _id;
        }

        public static int AllItemsCount
        {
            get => _allItemsCount;
        }

        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Name), value, InitialConstants.MaxLengthName);
                _name = value;
            }
        }

        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Info), value, InitialConstants.MaxLengthInfo);
                _info = value;
            }
        }

        public double Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertValueInRange(nameof(Cost), value, InitialConstants.MinValueCost, InitialConstants.MaxValueCost);
                _cost = value;
            }
        }

        public Item()
        {
            _allItemsCount++;
            _id = _allItemsCount;
        }

        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _allItemsCount++;
            _id = _allItemsCount;
        }
    }
}
