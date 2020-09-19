using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure f = new Figure(new Point("A", 1, 1), new Point("B", 1, 4), new Point("C", 4, 4), new Point("C", 4, 1));
            Console.WriteLine($"{f.GetFigureName()} {f.CaclulatePerimiter()}");
            Console.ReadKey();
        }
    }
}
