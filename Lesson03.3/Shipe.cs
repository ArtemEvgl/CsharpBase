using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson03._3
{
    class Shipe : Vehicle
    {
        readonly int quantityPassengers;
        readonly string port;
        public Shipe(int x, int y, int cost, int year, int speed, string port, int quantityPassengers)
            : base(x, y, cost, year, speed)
        {
            this.quantityPassengers = quantityPassengers;
            this.port = port;
        }

        public override void ShowParameters()
        {
            Console.WriteLine("Ship:");
            base.ShowParameters();
            Console.WriteLine($"{quantityPassengers} {port}");
        }
    }
}
