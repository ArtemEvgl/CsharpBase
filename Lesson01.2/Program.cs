using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side1: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side2: ");
            int side2 = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Perimiter = {rectangle.PerimiterCalculator()}, Area = {rectangle.AreaCalculator()}");
            Console.ReadKey();
        }
    }
}
