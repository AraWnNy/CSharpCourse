using System;

namespace Recap_Demo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu demoda loglama işlemini üç farklı şekilde yapılmasını ele aldık.
            //Veri tabanına, dosyaya ve sms'e loglama şeklinde.
            //Yazdığımız kodda ise interfaceleri kullanarak loglama işlemini dinamik hale getirdik.

            ILogger databaseLogger = new DatabaseLogger();
            ILogger fileLogger = new FileLogger();
            ILogger smsLogger = new SmsLogger();
            CustomerManager customerManger = new CustomerManager(smsLogger); //İstediğimiz şekilde loglamayı yapabiliyoruz.
            customerManger.Add();

            Console.Read();
        }
    }

    interface ILogger
    {
        void log();
    }

    class DatabaseLogger: ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger: ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class SmsLogger: ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to sms");
        }
    }

    class CustomerManager
    {
        private ILogger logger;

        public CustomerManager(ILogger logger)
        {
            this.logger = logger;
        }
        public void Add()
        {
            logger.log();
            Console.WriteLine("Customer added!");
        }
    }
}
