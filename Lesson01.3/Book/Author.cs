using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01._3
{
    class Author
    {
        string authorName;
        
        public Author(string name)
        {
            this.authorName = name;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(authorName);
            Console.ResetColor();
        }
    }
}
