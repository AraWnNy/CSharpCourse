using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Customer
    {
        public string fullName { get; set; }
        public string address { get; set; }
        public string mailAddress { get; set; }
        public string phoneNumber { get; set; }

        public Customer(string fullName, string address, string mailAddress, string phoneNumber)
        {
            this.fullName = fullName;
            this.address = address;
            this.mailAddress = mailAddress;
            this.phoneNumber = phoneNumber;
        }

        public Customer()
        {
            
        }
    }
}
