using System;

namespace Generics
{
    class Program
    {
        static Liste<string> myList;
        static void Main(string[] args)
        {
            //Bu projede generic yapısını kullanarak kendi liste yapımızı oluşturacağız.
            myList = new Liste<string>();

            Console.WriteLine(myList.elemanSayisi());
            myList.ekle("fikret");
            myList.ekle("ahmet");
            myList.ekle("ismail");
            myList.ekle("veli");
            myList.ekle("gökhan");
            myList.ekle("asma");
            Console.WriteLine(myList.elemanSayisi());
            listele();

            myList.sil(2);
            listele();
            Console.WriteLine(myList.elemanSayisi());

            myList.guncelle("fikret","tunahan");
            listele();

            Console.Read();
        }

        public static void listele()
        {
            for (int i = 0; i < myList.elemanSayisi(); i++)
            {
                Console.WriteLine(myList.getir(i));
            }
        }
    }
}
