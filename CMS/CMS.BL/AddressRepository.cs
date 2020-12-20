using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Avenida Ipiranga, 200";
                address.StreetLine2 = "Republica - SP";
                address.City = "São Paulo";
                address.State = "SP";
                address.Country = "Brasil";
                address.PostalCode = "01046010";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Avenida Ipiranga, 200",
                StreetLine2 = "Republica - SP",
                City = "São Paulo",
                State = "SP",
                Country = "Brasil",
                PostalCode = "01046010",
            };
            address.Add(address);

            Address address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Rua Migrantes, 200",
                StreetLine2 = "Ferrazópolis - SP",
                City = "São Bernardo do Campo",
                State = "SP",
                Country = "Brasil",
                PostalCode = "01046010",
            };
            address.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
