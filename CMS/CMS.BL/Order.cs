using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class Order
    {
        public Order(): this(0)
        {

        }

        public Order(int customerId, int shippingAddressId, int orderId) 
        {
                CustomerId = customerId;
                ShippingAddressId = shippingAddressId;
                OrderId = orderId;
        }
    
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTimeOffset? OrderDate { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
