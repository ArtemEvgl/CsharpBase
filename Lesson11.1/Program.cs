using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11._1
{
    class MyClass
    {
        public int MyProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            double b = 4.34;
            string c = "stringTest";
            MyClass myClass = new MyClass() { MyProperty = 2 };
            ArrayList arrayList = new ArrayList();

            arrayList.Add(a);
            arrayList.Add(b);
            arrayList.Add(c);
            arrayList.Add(myClass);

            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
