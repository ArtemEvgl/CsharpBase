using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15._1
{
    class Calculator
    {
        public int? Add(int? a, int b) => a + b;
        public int? Sub(int? a, int b) => a - b;
        public int? Mul(int? a, int b) => a * b;
        public int? Div(int? a, int b)
        {
            try
            {
                return a / b;
            }catch(DivideByZeroException)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("На нуль делить нельзя");
                Console.ResetColor();
                return null;
            }
        }
    }
}
