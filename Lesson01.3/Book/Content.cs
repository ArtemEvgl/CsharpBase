using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01._3
{
    class Content
    {
        string contentName;

        public Content(string name)
        {
            this.contentName = name;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(contentName);
            Console.ResetColor();
        }
    }
}
