using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public static class CustomerFactory
    {
        public static Customer DefaultCustomer()
        {
            Customer customer = new Customer();
            customer.FullName = "Full name";
            customer.Address = "Address";

            return customer;
        }
    }
}