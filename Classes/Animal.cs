using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Animal
    {
        public String name, color;
        public int age;

        public Animal(String name, String color, int age)
        {
            this.name = name;
            this.color = color;
            this.age = age;
        }

        public Animal()
        {

        }

        public static void getClassInfo()
        {
            Console.WriteLine("Bu sınıf hayvanlar ile ilgili verileri tutar. Bu metodun kullanılması için sınıfın örneklenmesi gerekmez.");
        }
    }
}
