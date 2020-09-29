using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson13._1
{

    
    class Program
    {
        static int deep;
        
        public static void Recursion()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} say hello");
            Thread thread = new Thread(Recursion) { Name = "Thread " + (++deep) };
            Thread.Sleep(500);
            thread.Start();
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(Recursion) { Name = "Thread " + deep };
            thread.Start();
        }
    }
}
