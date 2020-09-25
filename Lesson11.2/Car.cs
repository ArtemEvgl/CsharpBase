using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11._2
{
    class Car
    {
        private readonly string name;
        private readonly int year;

        public Car(string name, int year)
        {
            this.name = name;
            this.year = year;
        }

        public string Name => name;
        public int Year => year;
    }
}
