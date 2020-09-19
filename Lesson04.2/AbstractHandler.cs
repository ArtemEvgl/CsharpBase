using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._2
{
    abstract class AbstractHandler
    {
        protected string fileName;

        public AbstractHandler(string name)
        {
            fileName = name;
        }
        public void Create()
        {
            Console.WriteLine(fileName + "создан");
        }
        public void Open()
        {
            Console.WriteLine(fileName + "открыт");
        }
        public void Change()
        {
            Console.WriteLine(fileName + "изменен");
        }

        public abstract void Save();

    }

    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string name) : base(name)
        {
        }

        public override void Save()
        {
            Console.WriteLine("Сохранение xml документа");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string name) : base(name)
        {
        }

        public override void Save()
        {
            Console.WriteLine("Сохранение txt документа");
        }
    }
}
