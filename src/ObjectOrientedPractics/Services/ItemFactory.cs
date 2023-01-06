using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс создает шаблон для заполнения информации о товаре.
    /// </summary>
    public static class ItemFactory
    {
        /// <summary>
        /// Создание шаблона для заполнения информации о товаре.
        /// </summary>
        /// <returns>Шаблон для заполнения информации о товаре.</returns>
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
