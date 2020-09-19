using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._2
{
    class Redactor
    {
        AbstractHandler handler;

        public void ChooseDocument(string fileName)
        {
            var items = fileName.Split('.');
            switch(items.Last())
            {
                case "txt":
                    handler = new TXTHandler(fileName);
                    break;
                case "xml":
                    handler = new XMLHandler(fileName);
                    break;
                default:
                    Console.WriteLine("формат не определен");
                    break;
            }
        }

        public void Open()
        {
            handler.Open();
        }

        public void Craete()
        {
            handler.Create();
        }

        public void Change()
        {
            handler.Change();
        }

        public void Save()
        {
            handler.Save();
        }
    }
}
