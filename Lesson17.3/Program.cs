using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<dynamic, dynamic>
            {
                {new {Key = "table"},   new {Value = "стол" } },
                {new {Key = "apple"},   new {Value = "яблоко" } },
                {new {Key = "key"},   new {Value = "ключ" } },
                {new {Key = "car"},   new {Value = "машина" } }
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
            Console.ReadKey();
        }
    }
}
