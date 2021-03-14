using System.Collections.Generic;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        //retrieve one customer
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
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