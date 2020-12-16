using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class Customer
    {
        public string CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string FullName {
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
    }
}
