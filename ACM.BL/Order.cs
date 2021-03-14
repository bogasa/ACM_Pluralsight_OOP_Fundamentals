using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public Order(): this(0)
        {
                
        }
        public Order(int OrderId)
        {
            OrderId = OrderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public override string ToString()
        {
            return $"{OrderDate.Value.Date} ({OrderId}";
        }

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}