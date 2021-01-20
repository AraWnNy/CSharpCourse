using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu projede generic yapısını kullanarak kendi liste yapımızı oluşturacağız.
            Liste<string> myList = new Liste<string>();
            Console.WriteLine(myList.elemanSayisi());
            myList.ekle("fikret");
            myList.ekle("ahmet");
            myList.ekle("ismail");
            myList.ekle("veli");
            myList.ekle("gökhan");
            myList.ekle("asma");
            Console.WriteLine(myList.elemanSayisi());

            for (int i = 0; i< myList.elemanSayisi(); i++)
            {
                Console.WriteLine(myList.getir(i));
            }

            myList.sil(2);

            for (int i = 0; i < myList.elemanSayisi(); i++)
            {
                Console.WriteLine(myList.getir(i));
            }

            Console.WriteLine(myList.elemanSayisi());

            myList.guncelle("fikret","tunahan");
            for (int i = 0; i < myList.elemanSayisi(); i++)
            {
                Console.WriteLine(myList.getir(i));
            }
            Console.Read();
        }
    }
}
