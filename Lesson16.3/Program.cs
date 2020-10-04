using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Home home = new Home("Курск", new Street("Сумская"));
            Home homeClone = home.Clone();
            homeClone.City = "Москва";
            Console.WriteLine($"instance: {home}, cloneInstance:{homeClone}");
            Home homeDeepClone = home.DeepClone();
            homeDeepClone.City = "Ленинград";
            Console.WriteLine($"instance: {home}, deepCloneInstance:{homeDeepClone}");
            Console.ReadKey();
        }
    }
}
