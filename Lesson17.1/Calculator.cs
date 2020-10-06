using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17._1
{
    class Calculator
    {
        public static dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }

        public static dynamic Mul(dynamic a, dynamic b)
        {
            return a * b;
        }

        public static dynamic Sub(dynamic a, dynamic b)
        {
            return a - b;
        }

        public static dynamic Div(dynamic a, dynamic b)
        {
            if(b == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
                return null;
            } else
            {
                return a / b;
            }
        }
    }
}
