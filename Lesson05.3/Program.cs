using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(4,5);
            matrix.Show();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"matrix[1][2] = {matrix[1, 2]}");
            Console.WriteLine($"matrix[6][2] = {matrix[6, 2]}");
            matrix[0, 0] = 11;

            Console.WriteLine(new string('-', 30));
            matrix.ChangeSize(7,6);
            matrix.Show();

            Console.WriteLine(new string('-', 30));
            matrix.ShowPartly(1,0,4,4);

            Console.WriteLine(new string('-', 30));
            matrix.ChangeSize(2, 4);
            matrix.Show();

            Console.ReadKey();
        }
    }
}
