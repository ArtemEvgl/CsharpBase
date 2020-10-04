using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16._1
{
    struct Point
    {
        readonly int a, b, c;

        public Point(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A => this.a;
        public int B => this.b;
        public int C => this.c;

        public static Point operator +(Point one, Point second)
        {
            return new Point(one.a + second.a, one.b + second.b, one.c + second.c);
        }

        public override string ToString()
        {
            return $"a: {a}, b: {b}, c: {c}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point one = new Point(1,2,3);
            Point two = new Point(1,2,4);
            Point result = one + two;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
