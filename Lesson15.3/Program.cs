using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15._3
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceTable priceTable = new PriceTable();
            priceTable.FillData();
            Console.WriteLine("Введите навзвание магазина, чтобы получить список имеющихся товаров");
            string shopName = Console.ReadLine();
            Console.WriteLine(priceTable[shopName]);
            Console.ReadKey();
        }
    }
}
