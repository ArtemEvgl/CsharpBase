using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11._2
{
    class CarCollection<T>
    {
        private T[] array;

        public CarCollection()
        {
            array = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[array.Length] = item;
            array = tempArray;
        }

        public T this[int index]
        {
            get
            {
                if(index >= 0 && index < array.Length) 
                {
                    return array[index];
                } else
                {
                    Console.WriteLine("По указанному индексу значения не найдено");
                    return default(T);
                }
            }
        }

        public void Clear()
        {
            array = new T[0];
        }
    }
}
