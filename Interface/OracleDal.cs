using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class OracleDal: ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle veri tabanına eklendi...");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle veri tabanından silindi...");
        }

        public void Update()
        {
            Console.WriteLine("Oracle veri tabanında güncellendi...");
        }
    }
}
