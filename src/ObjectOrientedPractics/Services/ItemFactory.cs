using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public static class ItemFactory
    {
        public static Item DefaultItem()
        {
            Item item = new Item();
            item.Cost = 0;
            item.Name = "Name";
            item.Info = "Description";

            return item;
        }
    }
}
