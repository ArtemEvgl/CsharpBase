using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(10);
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList.Contains(10));
            Console.ReadLine();
        }
    }
}
