using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Deneme deneme = new Deneme();
            deneme.greetings2();
            Console.ReadLine();
        }
    }

    interface ıInterface
    {
        public void greetings();
        public void greetings2(String name  = "User");
    }

    class Deneme : ıInterface
    {
        public void greetings()
        {
            Console.WriteLine("Hello");
        }

        public void greetings2(string name = "User")
        {
            Console.WriteLine(String.Format("Hello {0}", name));
        }
    }
}
