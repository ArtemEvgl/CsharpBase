using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson09._2
{
    delegate double ArifmeticOperation(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите арифметическую операцию с 2 членами");
            string inputData = Console.ReadLine();
            
            Regex regexNumbers = new Regex(@"\d+");
            Regex symbol = new Regex(@"\+|-|\*|\/");
            
            int fistNumber = Convert.ToInt32(regexNumbers.Matches(inputData)[0].Value);
            int secondNumber = Convert.ToInt32(regexNumbers.Matches(inputData)[1].Value);
            string arifmeticSymbol = symbol.Match(inputData).Value;
            ArifmeticOperation ao = null;
            InitialDelegate(arifmeticSymbol, ref ao);

            Console.WriteLine(ao.Invoke(fistNumber, secondNumber));
            Console.ReadKey();
        }

        public static void InitialDelegate(string arifmeticSymbol, ref ArifmeticOperation ao)
        {
            switch (arifmeticSymbol)
            {
                case "+":
                    ao = (a, b) => a + b;
                    break;
                case "*":
                    ao = (a, b) => a * b;
                    break;
                case "-":
                    ao = (a, b) => a - b;
                    break;
                case "/":
                    ao = delegate (double a, double b) {
                        if (b != 0)
                        {
                            return a / b;
                        }
                        else
                        {
                            Console.WriteLine("На нуль делить нельзя");
                            return 0;
                        }
                    };
                    break;
                default:
                    ao = (a, b) =>
                    {
                        Console.WriteLine("Арифметический знак не найден");
                        return 0;
                    };
                    break;
            }
        }
    }
}
