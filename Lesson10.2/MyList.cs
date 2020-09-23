using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._2
{
    public class MyList<T> : IMyList<T>
    {
        private T[] massive;

        public MyList() {
            massive = new T[0];
        }

        public T this[int index]
        {
            get { return massive[index]; }
        }

        public int Count => massive.Length;
        
        public void Add(T element)
        {
            T[] tempArray = new T[massive.Length + 1];
            for (int i = 0; i < massive.Length; i++)
            {
                tempArray[i] = massive[i];
            }
            tempArray[massive.Length] = element;
            massive = tempArray;
        }

        public bool Contains(T item)
        {
            return massive.Contains(item);
        }

        public void Clear()
        {
            massive = new T[0];
            
        }


    }
}
