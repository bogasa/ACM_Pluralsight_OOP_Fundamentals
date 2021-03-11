using System;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
                
        }
        public Order(int OrderId)
        {
            OrderId = OrderId;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}