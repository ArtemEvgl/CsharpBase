using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Пушкин", "топ", "Ася");
            book.Show();
            Console.ReadKey();
        }
    }
}
