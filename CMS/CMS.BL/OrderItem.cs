using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (ProductId <= 0) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public OrderItem Retrieve(int productId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }
    }
}
