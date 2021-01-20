using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class SQLiteDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQLite veri tabanına eklendi...");
        }

        public void Delete()
        {
            Console.WriteLine("SQLite veri tabanından silindi...");
        }

        public void Update()
        {
            Console.WriteLine("SQLite veri tabanında güncellendi...");
        }
    }
}
