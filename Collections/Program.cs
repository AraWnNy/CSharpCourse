using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Arrayler yerine collectionsları kullanmamızın en büyük
             nedeni arraylerin static yani sabit; collectionsların ise dinamik olmasıdır.
             */

            //Kullanımı
            //Listelerde birçok veri türünü bir arada tutabiliriz.
            //Listi tanımlarken listenin tutacağı veri türünü belirtmek gerekir.
            /*List<object> myList = new List<object>();
            myList.Add(5);
            myList.Add("Text");
            myList.Add(true);

            foreach (object i in myList)
            {
                Console.WriteLine(i);
            }*/

            //Listedeki herhangi bir eleamını okuma
            //Console.WriteLine(myList[0]);


            //Gelişmiş bir örnek uygulama

            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer("Fikret Gözütok", "Kütahya", "fikret@mail.com", "05121211212"));
            customerList.Add(new Customer("Gözde Şahin", "Kocaeli", "gozde@mail.com", "0542223422"));
            customerList.Add(new Customer("Ali Berk Doğan", "Antalya", "aliberk@mail.com", "054254234543"));
            customerList.Add(new Customer("Ataman Demir", "İstanbul", "ataman@mail.com", "052341234312"));

            Console.WriteLine(String.Format("Sistemde kayıtlı olan müşteri sayısı = {0}\n", customerList.Count));
            foreach (Customer customer in customerList)
            {
                Console.WriteLine(String.Format("Müşteri Bilgileri\nAdı = {0}\nAdresi = {1}\nMail = {2}\nTelefon Numarası = {3}\n\n", 
                    customer.fullName, customer.address, customer.mailAddress, customer.phoneNumber));
            }

            Console.Read();
        }
    }
}
