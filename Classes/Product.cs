using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Product
    {
        private int ID;
        private String name;
        private String date;


        public Product(String name, String date)
        {
            this.name = name;
            this.date = date;
        }

        public int getID()
        {
            Random random = new Random();
            return random.Next(0,10);
        }

        public String getName()
        {
            return this.name;
        }

        public String getDate()
        {
            return this.date;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setDate(String date)
        {
            this.date = date;
        }

       
    }
}
