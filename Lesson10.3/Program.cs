using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary= new MyDictionary<string, string>();
            dictionary.Add("value", "key");
            Console.WriteLine(dictionary[0]);
            Console.WriteLine(dictionary["key"]);
            dictionary.Add("value2", "key");
            Console.WriteLine(dictionary[0]);
            Console.ReadKey();

        }
    }
}
