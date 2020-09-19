using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter handlerDocument");
            string documentName = Console.ReadLine();
            Redactor redactor = new Redactor();
            redactor.ChooseDocument(documentName);
            redactor.Open();
            redactor.Change();
            redactor.Save();

            Console.ReadKey();
        }
    }
}
