using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tanımlama
            /*string[] isimler = new string[5];
            isimler[0] = "Ahmet";
            isimler[1] = "Mehmet";
            isimler[2] = "Hasan";
            isimler[3] = "Veli";
            isimler[4] = "Arif";

            for (int i = 0; i<isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            Console.WriteLine("İsimler listesinin uzunluğu = {0}",isimler.Length);

            
            int[] sayilar = new int[] {5,4,3,2,1};
            Console.WriteLine("sayilar arrayinin ilk elemanı = " + sayilar[0]);*/

            //Çok boyutlu diziler

            string[,] bolgeSehir = new string[3,2];
            bolgeSehir[0,0] = "Kütahya";
            bolgeSehir[0,1] = "İzmir";
            bolgeSehir[1,0] = "Bilecik";
            bolgeSehir[1,1] = "İstanbul";
            bolgeSehir[2, 0] = "Ankara";
            bolgeSehir[2, 1] = "Konya";

            for (int i = 0; i<=bolgeSehir.GetUpperBound(0); i++)
            {
                for (int a = 0; a<=bolgeSehir.GetUpperBound(1); a++)
                {
                    Console.WriteLine(bolgeSehir[i,a]);
                }
                Console.WriteLine("************");
            }


            Console.ReadLine();


        }
    }
}
