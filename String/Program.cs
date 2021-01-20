using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "Tevfik";
            string metin_bosluk = "        Boşluk Karakteri            ";
            string metin_bolme = "Bugün-hava-çok-güzel.";

            //İterable Obje
            /*foreach (char harf in metin)
            {
                Console.WriteLine(harf);
            }*/

            Console.WriteLine(metin.Length);
            Console.WriteLine(metin[0]);
            Console.WriteLine(metin.Equals("Tevfik"));
            Console.WriteLine(metin_bosluk.Trim());
            Console.WriteLine(metin.ToUpper());
            Console.WriteLine(metin.ToLower());
            string[] dizi = metin_bolme.Split("-");
            Console.WriteLine(dizi.Length);
            Console.WriteLine(metin.Substring(2,2));
            Console.WriteLine(metin_bolme.Replace('-',' '));
            Console.WriteLine(metin.IndexOf('k'));
            Console.WriteLine(metin.LastIndexOf('k'));
            Console.WriteLine(metin.Insert(metin.Length, " Fikret"));
            Console.WriteLine(metin.Remove(2,2));

            //Referans Tip
            Console.WriteLine("*********************************");
            string metin2 = "Ahmet";
            string yeni_metin = (string)metin2.Clone();
            metin2 = "Kasım";

            Console.WriteLine(metin2 + "\n" + yeni_metin);


            Console.ReadLine();
        }
    }
}
