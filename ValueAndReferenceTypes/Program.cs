using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Değer ve Referans Tipleri

             Bellekte iki adet kısım vardır. Stack ve Heap. Değer tiplerinin tuttuğu değerler stackte tanımlanır ve tanımlandığı değişkene özgüdür. Referans tiplerde ise
             değişkenin tuttuğu değer heapte tutulur ve stackde bulunan değişkene heapdeki verinin adresi atanır.

             int, float, double, bool gibi tipler değer;
             string, array, class, interface gibi tipler referans tiptir. 
             */

            int n1 = 10;
            int n2 = 20;
            n1 = n2;
            n2 += 10;
            Console.WriteLine(n1);


            int[] a1 = new int[] {1,2,3};
            int[] a2 = new int[] {5,15,25};
            a1 = a2;
            a2[0] = 0;
            Console.WriteLine(a1[0]);

            //ref_out parametreleri
            //Normalde bir metoda parametre gönderdiğimizde o parametrenin değerini göndeririz. Eğer metotda aldığımız değişkeni değiştirmek yani aldığımız değişkenin
            //adresini almak istersek ref veya out paremetrelerinden yararlanırız. Ref parametresi gönderilen değerin initailize edilmesini istersen out da böyle bir 
            //zorunluluk yoktur.

            int number = 10;
            int number2 = 0;

            Console.WriteLine(String.Format("Ref Metodundan Önce Number = {0}",number));
            Console.WriteLine(String.Format("Ref Metodu Çalıştı = {0}",sum_ref(ref number)));
            Console.WriteLine(String.Format("Ref Metodundan Sonra Number = {0}", number));

            Console.WriteLine(String.Format("Out Metodundan Önce Number2 = {0}", number2));
            Console.WriteLine(String.Format("Out Metodu Çalıştı = {0}", sum_out(out number2)));
            Console.WriteLine(String.Format("Out Metodundan Sonra Number2 = {0}", number2));


            Console.Read();
        }

        public static int sum_ref(ref int x)
        {
            return x = 20;
        }

        public static int sum_out(out int x)
        {
            return x = 10;
        }
    }
}
