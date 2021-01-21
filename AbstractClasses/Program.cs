using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract classlar hem tamamlanmış metodları hem de tamamlanmamış, o class'ı inherit eden class tarafından tanımlanması/içi doldurulması gereken virtual methodlardır.
            //Abstract classlar newlenemez/örneklenemez(Bu yönden interfaceler gibidir.)

            Database oracle = new Oracle();
            Database sql = new SQL();

            oracle.Add();
            oracle.getAllData();

            sql.Add();
            sql.getAllData();

            Oracle o = new Oracle();
            o.Add();
            o.getAllData();

            Console.Read();
        }
    }

    abstract class Database
    {
        //Bu örnekte veri tabanına veri eklemeyi her veri tabanında aynı kabul edelim.
        //Yalnız verileri çekmek her veri tabanı için farklı olsun.
        //Bu noktada verileri çekme işlemini bu classı inherit eden her class'ın override etmesi gerekir.
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void getAllData();
    }

    class Oracle: Database
    {
        public override void getAllData()
        {
            Console.WriteLine("All data getted by oracle code");
        }
    }

    class SQL: Database
    {
        public override void getAllData()
        {
            Console.WriteLine("All data getted by sql code");
        }
    }
}
