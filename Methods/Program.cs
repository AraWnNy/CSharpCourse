using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            greetings();
            greetings("Ali");

            sayWelcome("AraWnNy");

            int a = 10;
            int b = 20;
            Console.WriteLine("Metoddan dönen = {0}\na nın değeri = {1}",summery(ref a,b), a);

            Console.WriteLine(topla(6,5,4,3,2,1));

            Console.ReadLine();
        }


        //Metod overloading
        static void greetings()
        {
            Console.WriteLine("Hello");
        }
        static void greetings(String name)
        {
            Console.WriteLine("Hello {0}", name);
        }
        //

        //Default Parametreli Metod
        static void sayWelcome(String name = "User")
        {
            Console.WriteLine("Welcome {0}", name);
        }


        //Ref keywordü
        static int summery(ref int a, int b)
        {
            a+=10;
            return a + b;
        }

        //out keywordü
        //ref ile tamamen aynı sadece başta değişkenin initialize edilmesine gerek yok. refte initialize zorunlu

        //params keywordü
        static int topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i<sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }

    }

    public class Test
    {
        //Bu class AccessModifiers projesinde kullanılıyor.
    }
}
