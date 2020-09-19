using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Alex", "Fox") { Article = "Iphone", Quantity = 6 };

            invoice.CalculateCost();
            Console.ReadKey();
        }
    }
}
