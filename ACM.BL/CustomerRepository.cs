using System.Collections.Generic;

namespace ACM.BL
{
    public class CustomerRepository
    {
        //retrieve one customer
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAddress = "bogasa@gmail.com";
                customer.FirstName = "Bogdan";
                customer.LastName = "Asaftei";
            }

            return customer;
        }
        //public List<Customer> Retrieve()
        //{
        //    return new List<Customer>();

        //}
        //saves the current customer
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}