using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15._2
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkController comp = new WorkController(); //Создание экземпляра класса Company
            comp.FillData();
            Console.WriteLine(comp[5]); //Отображение результата вызова индексатора

            // Delay.
            Console.ReadKey();
        }
    }
}
