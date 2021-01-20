using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Liste<T>
    {
        T[] array;

        public Liste()
        {
            array = new T[0];
        }
        public void ekle(T eleman)
        {
            T[] tempArray = new T[(array.Length)+1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[array.Length] = eleman;
            array = tempArray;
            
        }

        public int elemanSayisi()
        {
            return array.Length;
        }

        public T getir(int i)
        {
            return array[i];
        }

        public void sil(int index)
        {
            T[] tempArray = new T[(array.Length)-1];
            T deletedData = getir(index);
            int i = 0;
            foreach (T item in array)
            {
                if (item.Equals(deletedData))
                {
                    
                    continue;
                }
                else
                {
                    tempArray[i] = item;
                    i++;
                }
            }
            array = tempArray;
        }

        public void guncelle(T exItem, T newItem)
        {
            for(int i = 0; i<array.Length; i++)
            {
                if (array[i].Equals(exItem))
                {
                    array[i] = newItem;
                }
            }
        }
    }
}
