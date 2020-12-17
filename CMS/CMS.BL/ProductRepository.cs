using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class ProductRepository
    {
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public Product Retrieve(int productId)
        {
            Product product = new Product(1);

            if (productId == 1)
            {
                product.ProductName = "Bun Ginganga";
                product.Description = "Aquele negósso que faz isso";
                product.CurrentPrice = 65.44M;
            }
            return product;
        }

        public bool Save()
        {
            return true;
        }
    }
}
