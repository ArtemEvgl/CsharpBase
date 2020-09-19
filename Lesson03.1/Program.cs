using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer[] printers = new Printer[3];
            printers[0] = new Printer();
            printers[1] = new PrinterYellow();
            printers[2] = new PrinterBlue();
            PrintText(printers, "test");
            Console.ReadKey();
        }

        public static void PrintText(Printer[] printers, string value) {
            foreach(var printer in printers)
            {
                printer.Print(value);
            }
        }
    }
}
