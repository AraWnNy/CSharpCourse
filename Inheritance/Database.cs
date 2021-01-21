using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Database
    {

        //Aslında virtual methods dediğimiz olay var olan metodun kalıtılan sınıfta ezilmesi yani yeniden tanımlanmasıdır.
        //virtual ve override keywordleri kullanılır.

        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }

    }

    class Oracle: Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by oracle code");
            //base.Add(); //Base ana sınıf olan Database' e referans verir. Bu kod Database class'ında ki Add() metodunu çağırır. 
        }

        public override void Delete()
        {
            Console.WriteLine("Deleted by oracle code");
        }
    }

    class SQL: Database
    {

    }
}
