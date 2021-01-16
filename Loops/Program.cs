using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Loop
            /*for (int i = 1; i<100; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }*/

            //While Loop
            /*int counter = 0;

            while (counter < 100)
            {
                if (counter % 5 == 0) Console.WriteLine(counter);
                counter++;
            }*/

            /*int counter = 0;
            while (true)
            {
                Console.WriteLine(counter);
                if (counter == 14)
                {
                    break;
                }
                counter++;
            }*/

            //Foreach Loop

            /*string[] isimler = new string[5];

            for (int i = 0; i<isimler.Length; i++)
            {
                Console.Write("Bir isim gir = ");
                isimler[i] = Console.ReadLine();
            }

            Console.WriteLine("İşte girdiğin isimlerin tamamı");

            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }*/

            //Do-While Loop

            /*int counter = 10;

            do
            {
                Console.WriteLine("OK");
            } while (counter < 5);*/

            //Console.WriteLine("Döngü sonu");



            //Örnek - Asal Sayı

            /*Console.Write("Sayı gir = ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            bool control = true;

            for (int i = 2; i<sayi; i++)
            {
                if (sayi%i == 0)
                {
                    control = false;
                    break;
                }
            }

            Console.WriteLine(control ? "Sayı asal": "Sayı asal değil");*/

            Console.ReadLine();
        }
    }
}
