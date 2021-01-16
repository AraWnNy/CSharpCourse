using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            short s1 = 254;
            int s2 = 23424;
            long s3 = 2479789047389207478;

            bool control = true;

            char karakter = 'A';

            string city = "Kütahya";

            float ondalikli = 5.4f;

            double ondalikli_2 = 54.3;

            decimal ondalikli_3 = 232.332413m;

            Console.WriteLine(Days.Çarşamba);

            var neOlduguBilinmeyen = "Kerem";

            Console.ReadLine();
        }
           enum Days
        {
            Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar
        }
    }
}
