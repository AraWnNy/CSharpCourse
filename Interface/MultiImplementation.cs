using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface MultiImplementation
    {
        //Bir şirkette üç tane çalışan sınıf olduğunu düşünelim.
        //Yöneticiler, İşçiler, Robotlar
    }

    interface IWork
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void Salary();
    }

    class Manager:IWork, IEat, ISalary
    {
        public void Work()
        {
            Console.WriteLine("Yönetici çalışıyor...");
        }

        public void Eat()
        {
            Console.WriteLine("Yönetici yemek yiyor...");
        }

        public void Salary()
        {
            Console.WriteLine("Yönetici maaş alıyor...");
        }
    }

    class Worker: IWork, IEat, ISalary
    {
        public void Work()
        {
            Console.WriteLine("İşci çalışıyor...");
        }

        public void Eat()
        {
            Console.WriteLine("İşci yemek yiyor...");
        }

        public void Salary()
        {
            Console.WriteLine("İşci maaş alıyor...");
        }
    }

    class Robot: IWork
    {
        public void Work()
        {
            Console.WriteLine("Robot çalışıyor...");
        }
    }
}
