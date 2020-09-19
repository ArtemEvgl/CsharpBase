using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06._4
{
    static class ExtensionClass
    {
        public static void MySort(this int[] massive)
        {
            for(int i = 0; i < massive.Length; i++)
            {
                for(int j = massive.Length - 1; j > i; j--)
                {
                    if (massive[i] > massive[j])
                    {
                        int temp = massive[i];
                        massive[i] = massive[j];
                        massive[j] = temp;
                    }
                }
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] massive = { 1, 5, 10, 2, 11, 2, 15, 3 };
            massive.MySort();
        }
    }
}
