using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03._1
{
    class PrinterYellow : Printer
    {
        override public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
