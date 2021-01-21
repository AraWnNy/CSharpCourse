using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance => Kalıtım/Miras Alma
            //Interface => Implementation // Class => Inheritance
            //Bir class aynı anda birden fazla interface' i implemente edebilirken sadece bir tane class' ı inherit edebilir.

            //=> Person.cs

            Person customer_p = new Customer();
            customer_p.FirstName = "Fikret";
            customer_p.LastName = "Gözütok";
            customer_p.ID = 0;

            Customer customer_n = new Customer();
            customer_n.FirstName = "İsmail";
            customer_n.LastName = "Demir";
            customer_n.ID = 1;
            customer_n.Address = "Kütahya";
            customer_n.live();

            IPerson[] personList = new IPerson[]
            {
                new Customer
                {
                    FirstName = "Tunahan",
                    LastName = "İbiroğlu",
                    ID = 2,
                    Address = "Balıkesir"
                },
                new Student
                {
                    FirstName = "Hüseyin",
                    LastName = "Asma",
                    ID = 3,
                    Department = "Lise" 
                }
            };

            foreach (IPerson person in personList)
            {
                person.live();
            }

            Console.WriteLine("\n\n\n");

            //Virtual Methods
            //Database.cs

            Oracle oracle = new Oracle();
            SQL sql = new SQL();

            oracle.Add();
            sql.Add();

            oracle.Delete();
            sql.Delete();


            Console.Read();
        }
    }
}
