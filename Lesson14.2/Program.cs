using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14._2
{

    static class MyClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] result = new T[list.Count()];
            int i = 0;
            foreach (var item in list)
            {
                result[i] = item;
                i++;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove(3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            int[] array = list.GetArray();

            Console.ReadKey();
        }
    }
}
