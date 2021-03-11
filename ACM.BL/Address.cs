namespace ACM.BL
{
    public class Address
    {
        public Address()
        {
            
        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }
        public int AddressId { get; private set; }

        public bool Validate()
        {
            var isValid = true;
            if (PostalCode == null) isValid = false;
            return isValid;
        }
    }
}