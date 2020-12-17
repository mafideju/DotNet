using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class Customer
    {

        public Customer()
        {
            
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string FullName 
        {
            get 
            {
                string fullname = FirstName;
                if(!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += " ";
                    }
                    fullname += LastName;
                }
                return fullname; 
            } 
        }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
