using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01._4
{
    class Point
    {
        string name;
        int x, y;

        public string Name { get { return name; } }
        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Point(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }
    }
}
