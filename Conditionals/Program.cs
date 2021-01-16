using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan veri alma

            int sayi;
            Console.Write("Sayı giriniz = ");
            sayi = Convert.ToInt32(Console.ReadLine());

            //If Bloğu
            /*if (sayi > 0)
            {
                Console.WriteLine("Sayı pozitif");
            }
            else if (sayi < 0) Console.WriteLine("Sayı negatif");
            else Console.WriteLine("Sayı 0");*/

            //Single Line If
            /*Console.WriteLine(sayi > 0 ? "Sayı Pozitif" : "Sayı Negatif");*/


            //Switch-Case Yapısı
            /*switch (sayi)
            {
                case 5:
                    Console.WriteLine("Sayı 5 tir");
                    break;
                case 10:
                    Console.WriteLine("Sayı 10 dur");
                    break;
                default:
                    Console.WriteLine("Sayı 5 veya 10 değildir");
                    break;

            }*/

            Console.ReadLine();

      

        }
    }
}
