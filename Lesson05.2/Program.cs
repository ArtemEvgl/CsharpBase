using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(5);
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min());
            Console.WriteLine(array.Sum());
            Console.WriteLine(array.Averrage());
            array.Odd();
            Console.ReadKey();
        }
    }
}
