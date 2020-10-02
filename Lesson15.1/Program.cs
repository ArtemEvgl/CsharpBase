using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            string inputData = Console.ReadLine();

            Regex regexNumbers = new Regex(@"\d+");
            Regex regexSymbol = new Regex(@"\-|\+|\*|\/");

            MatchCollection numbersCollection = regexNumbers.Matches(inputData);
            MatchCollection symbolCollection = regexSymbol.Matches(inputData);

            int? result = Convert.ToInt32(numbersCollection[0].ToString());
            for (int i = 0, j = 1; i < symbolCollection.Count; i++, j++)
            {
                int nextNumber = Convert.ToInt32(numbersCollection[j].ToString());
                switch (symbolCollection[i].ToString())
                {
                    case "+":
                        result = calculator.Add(result, nextNumber);
                        break;
                    case "-":
                        result = calculator.Sub(result, nextNumber);
                        break;
                    case "*":
                        result = calculator.Mul(result, nextNumber);
                        break;
                    case "/":
                        result = calculator.Div(result, nextNumber);
                        break;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
