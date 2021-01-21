using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person, IPerson
    {
        public string Address { get; set; }

        public void live()
        {
            Console.WriteLine("Customer.Live");
        }
    }

    class Student : Person, IPerson
    {
        public string Department { get; set; }

        public void live()
        {
            Console.WriteLine("Student.Live");
        }
    }

    interface IPerson
    {
        void live();
    }


   
}
