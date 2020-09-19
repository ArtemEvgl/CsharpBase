using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson03._3
{
    class Plane : Vehicle
    {
        readonly int height, quantityPassengers;

        public Plane(int x, int y, int cost, int year, int speed, int height, int quantityPassengers) : base(x, y, cost, year, speed)
        {
            this.quantityPassengers = quantityPassengers;
            this.height = height;
        }

        public override void ShowParameters()
        {
            Console.WriteLine("Plane");
            base.ShowParameters();
            Console.WriteLine($"{height} {quantityPassengers}");
        }
    }
}
