using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08._2
{

    enum EnumColors
    {
        Red = 1,
        Blue,
        Yellow
    }
    static class OutputData
    {
        public static void Print(string data, int color)
        {
            switch(color)
            {
                case (int)EnumColors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)EnumColors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)EnumColors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.WriteLine("Number of color not found. Console color is default (gray)");
                    break;
            }
            Console.WriteLine(data);
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the data:");
            string data = Console.ReadLine();
            Console.WriteLine("Choose the number of color:");
            Console.WriteLine("1. Red");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Yellow");
            int color = Convert.ToInt32(Console.ReadLine());
            OutputData.Print(data, color);
            Console.ReadKey();
        }

        
    }
}
