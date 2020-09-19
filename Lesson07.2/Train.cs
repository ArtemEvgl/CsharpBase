using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07._2
{
    struct Train
    {
        readonly string destination;
        readonly DateTime date;
        readonly int number;

        public Train(string destination, string date, int number)
        {
            this.destination = destination;
            this.date = DateTime.Parse(date);
            this.number = number;
        }

        public int Number { get { return number; } }
        public string Destination { get { return destination; } }
        public DateTime DateTime { get { return date; } }

        public void ShowTrainInfo()
        {
            Console.WriteLine($"Поезд номер {number} отправляется {date} в {destination}");
        }
    }
}
