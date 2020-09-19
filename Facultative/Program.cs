using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Facultative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите путь к файлу .txt");
            string path = Console.ReadLine();

            string exit = "n";
            while(exit != "y")
            {
                Console.WriteLine(new string('=', 80));
                string text = GetText(path);

                Console.WriteLine("Введите текст который надо найти:");
                string findText = Console.ReadLine();
                Console.WriteLine(new string('=', 80));
                ToFindText(text, findText);

                ToExit(ref exit);
            }
            
        }

        public static void ToExit(ref string exit)
        {
            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Выйти? y/n");
            exit = Console.ReadLine();
            Console.WriteLine(new string('=', 80));
        }

        public static string GetText(string path)
        {            
            using(StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string text = sr.ReadToEnd();
                Console.WriteLine(text);
                Console.WriteLine(new string('=', 80));
                return text;
            }
        }

        public static void ToFindText(string text, string findText)
        {
            int findCursor = 0;
            int index = 0;
            do
            {
                findCursor = text.IndexOf(findText, index);
                if (findCursor != -1)
                {
                    string textBeforeFindWord = text.Substring(index, findCursor - index);
                    Console.Write(textBeforeFindWord);
                    Console.ForegroundColor = ConsoleColor.Red;
                    string findWord = text.Substring(findCursor, findText.Length);
                    Console.Write(findWord);
                    Console.ResetColor();
                    index = findCursor + findText.Length;
                }

            } while (findCursor != text.Length && findCursor != -1);
                if (index != text.Length)
            {
                Console.WriteLine(text.Substring(index));
            }
        }
    }
}
