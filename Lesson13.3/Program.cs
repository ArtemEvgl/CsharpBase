using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80,40);
            Matrix matrix;
            for (int i = 0; i < 30; i++)
            {
                matrix = new Matrix(i * 2, true);
                new Thread(matrix.Move).Start();
            }
            Console.ReadKey();
        }
    }
}
