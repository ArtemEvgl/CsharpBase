using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09._1
{

    delegate double ArifmeticOperation(double a, double b, double c);
    class Program
    {
        static void Main(string[] args)
        {
            ArifmeticOperation arifmeticOperation = (a, b, c) => (a + b + c) / 3;
            Console.WriteLine("result {0:f2}", arifmeticOperation?.Invoke(2, 3, 5));
            Console.ReadLine();
        }
    }
}
