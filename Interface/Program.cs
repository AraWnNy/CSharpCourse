using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfacelerin kullanım şekilleri 
            CustomerManager customerManger = new CustomerManager();
            //customerManger.Add(new SQLiteDal());
            //customerManger.Delete(new OracleDal());

            ICustomerDal[] customerDals = new ICustomerDal[]
            {
                new SQLiteDal(),
                new OracleDal()
            };

            foreach (ICustomerDal customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Delete();
                customerDal.Update();
            }

            //Çoklu implementasyon örneği için MultiImplementation.cs bakınız...
            //Devamı

            IWork[] workersArray = new IWork[]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            IEat[] eatArray = new IEat[]
            {
                new Manager(),
                new Worker()
            };

            ISalary[] salaryArray = new ISalary[]
            {
                new Manager(),
                new Worker()
            };

            foreach (IWork worker in workersArray)
            {
                worker.Work();
            }

            foreach (IEat eater in eatArray)
            {
                eater.Eat();
            }

            foreach (ISalary salaryGetter in salaryArray)
            {
                salaryGetter.Salary();
            }

            Console.Read();
        }
    }

    
}
