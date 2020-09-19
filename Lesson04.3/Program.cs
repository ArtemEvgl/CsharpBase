using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IRecodable ir = player as IRecodable;
            ir.Record();
            Console.ReadLine();
        }
    }
}
