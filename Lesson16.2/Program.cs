using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(1,2,3,4);
            Block block2 = new Block(1,2,3,4);
            Console.WriteLine(block1.Equals(block2));
            Console.ReadKey();
        }
    }
}
