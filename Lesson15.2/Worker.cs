using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15._2
{
    struct Worker
    {
        string name;
        string position;
        DateTime dateTime;

        public Worker(string name, string position, DateTime dateTime)
        {
            this.name = name;
            this.position = position;
            this.dateTime = dateTime;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Position { get { return position; } set { position = value; } }
        public DateTime DateTime { get { return dateTime; } set { DateTime = value; } }
        public int Experience { get { return DateTime.Now.Year - this.dateTime.Year; } }

        public override string ToString()
        {
            return $"{Name} занимает {position} с {DateTime.ToString("d")}";
        }
    }
}
