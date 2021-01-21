using System;
using Methods; //Proje altındaki dependencies'e sağ tıklayarak methods projesinin referansını ekliyoruz. Daha sonra ise using komutu ile projemize dahil ediyoruz.

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Access Modifiers => Erişim Bildirgeçleri
            //private => Sadece tanımlandığı blok içerisinde kullanılabilir.
            //protected => private ile aynıdır. Tek farkı tanımlandığı class inherit edildiğindede kullanılabilir.
            //internal => bütün proje içinden erişilebilir. Classlar ve Interfaceler örnektir.
            //public => Başka projelerden de erişilebilir.


            //public class mantığı ile Methods projesinde bulunan Test Class'ına erişim sağlayalım.
            //usin Methods; dedikten sonra Test class'ı erişilebilir olucaktır.
            Test test = new Test();


        }
    }

    class Demo1
    {
        private string field1 { get; set; }
        protected string field2 { get; set; }

        public void function1()
        {
            string fieldDemo; //Varsayılan olarak private
        }

        public void function2()
        {
            //fieldDemo private olduğu için gelmez.(protected'de burada aynı şekilde çalışır.)
        }
    }

    class Demo2: Demo1
    {
        public void functionTest()
        {
            //field1 private olduğu için gelmez
            Console.WriteLine(field2); //field2 protected olduğu için gelir.
        }
    }

    internal class Demo3
    {
        //internal bulunduğu proje içinde heryerden ulaşılabilir idi.
        //classlar private veya protected olamaz.Ya internal ya da public.
        //Sadece inner classlar private veya protected olabilir.

        private class InnerClass
        {

        }

        internal class NotPrivateInnerClass
        {

        }
    }
}
