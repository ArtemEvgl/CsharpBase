using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._1
{

    class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program program = MyClass<Program>.FactoryMethod();
            Console.WriteLine(program.GetType().ToString());
            Console.ReadLine();
        }
    }
}
