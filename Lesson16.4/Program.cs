using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime1 = new DateTime(1995, 11, 25);
            DateTime dateTime2 = new DateTime(1997, 12, 31);
            
            MyDate date1 = new MyDate(25, 11, 1995);
            MyDate date2 = new MyDate(31, 12, 1997);
            
            Console.WriteLine(date2 - date1);
            Console.WriteLine((dateTime2 - dateTime1).TotalDays);
            Console.ReadKey();
        }
    }
}
