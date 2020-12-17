using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class CustomerRepository
    {
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(1);

            if(customerId == 1)
            {
                customer.EmailAddress = "mafideju@outlook.com";
                customer.FirstName = "Márcio";
                customer.LastName = "Rodrigues";
            }
            return customer;
        }

        public bool Save()
        {
            return true;
        }
    }
}
