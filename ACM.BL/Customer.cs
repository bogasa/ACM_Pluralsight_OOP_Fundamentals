using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public string FirstName { get; set; }
        private string _lastName;
        public string EmailAddress { get; set; }
        public int CustomerID { get; private set; }
        public static int InstanceCount { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

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
        //validate the customer data
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
        
    }
}
