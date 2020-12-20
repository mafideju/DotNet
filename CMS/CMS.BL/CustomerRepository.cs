using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class CustomerRepository
    {
        public CustomerRepository() 
        {
            addressRepository = new addressRepository();
        }

        private AddressRepository addressRepository { get; set; }

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
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
