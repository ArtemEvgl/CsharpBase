using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Vasya", "Puokin");
            employee.Experience = 1;
            employee.Post = "dev";
            employee.ShowSalary();
            Console.ReadKey();
        }
    }
}
