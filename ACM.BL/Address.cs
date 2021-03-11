namespace ACM.BL
{
    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string AddressType { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (AddressType == null) isValid = false;
            return isValid;
        }
    }
}