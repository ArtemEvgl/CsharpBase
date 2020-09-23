using Lesson10._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson10._4
{
    static class ExtendedClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
    }

    class Program
    {
        
        
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            int[] array = myList.GetArray<int>();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
