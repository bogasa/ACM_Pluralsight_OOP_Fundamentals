using System.Collections.Generic;

namespace ACM.BL
{
    public class CustormerRepository
    {
        //retrieve one customer
        public Customer Retrieve(int customerID)
        {
            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();

        }
        //saves the current customer
        public bool Save()
        {
            return true;
        }
    }
}