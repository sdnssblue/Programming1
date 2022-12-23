using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Предоставляет реализацию расположения элементов на форме.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Покупатели и товары.
        /// </summary>
        private Store _store;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {
            if (ProjectSerializer.IsFile("Store"))
            {
                _store = ProjectSerializer.Deserialize("Store");
            }
            else
            {
                _store = new Store();
            }

            InitializeComponent();

            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectSerializer.Serialize("Store", _store);
        }

        private void TabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (TabControl.SelectedIndex == 2)
            {
                CartsTab.Items = ItemsTab.Items;
                CartsTab.Customers = CustomersTab.Customers;
                CartsTab.RefreshData();
            }
            else if (TabControl.SelectedIndex == 3)
            {
                OrdersTab.Customers = CartsTab.Customers;
                OrdersTab.RefreshData();
            }
        }
    }
}
