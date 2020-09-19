using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();
            
            Console.WriteLine(dictionary["apple"]);
            Console.WriteLine(dictionary["папа"]);
            Console.WriteLine(dictionary["матько"]);

            for(int i = 0; i < 6; i++) 
            {
                Console.WriteLine(dictionary[i]);
            }
            Console.ReadKey();
        }
    }
}
