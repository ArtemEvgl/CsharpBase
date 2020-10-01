using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary= new MyDictionary<string, string>();
            dictionary.Add("table","стол");
            dictionary.Add("house", "дом");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
