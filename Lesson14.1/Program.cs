using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14._1
{
    class Program
    {
        
        static IEnumerable FindEven(int[] arr)
        {
            if(arr.Length >= 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        yield return arr[i];
                    }
                }
            } else
            {
                yield break;
            }
        }
        
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (var item in FindEven(array))
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }
    }
}
