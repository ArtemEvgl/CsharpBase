using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01._3
{
    class Title
    {
        string titleName;
        public Title(string name)
        {
            this.titleName = name;
        }

        public void Show()
        {           
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(titleName);
            Console.ResetColor();
        }
    }
}
