using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03._1
{
    class PrinterBlue : Printer
    {

        override public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
