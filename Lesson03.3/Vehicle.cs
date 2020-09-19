using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson03._3
{
    class Vehicle
    {
        int x, y;
        readonly int cost, year, speed;

        public int X { get; set; }
        public int Y { get; set; }

        public Vehicle(int x, int y, int cost, int year, int speed)
        {
            this.x = x;
            this.y = y;
            this.cost = cost;
            this.year = year;
            this.speed = speed;
        }

        public virtual void ShowParameters()
        {
            Console.WriteLine($"{x} {y} {cost} {year} {speed}");
        }
    }
}
