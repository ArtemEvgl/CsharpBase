using System;

namespace Lesson03._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Plane(12,11,500000,2003,40,23,700);
            v.ShowParameters();
            Console.ReadKey();
        }
    }
}
