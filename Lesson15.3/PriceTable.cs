using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15._3
{
    class PriceTable
    {
        struct Price
        {

            private string name;
            private string shopName;
            private uint? cost;
            public Price(string name, string shopName, uint? cost)
            {
                this.name = name;
                this.shopName = shopName;
                this.cost = cost;
            }

            

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            

            public uint? Cost
            {
                get { return cost; }
                set { cost = value; }
            }

            

            public string ShopName
            {
                get { return shopName; }
                set { shopName = value; }
            }

            public override string ToString()
            {
                return $"{name} из {shopName} по цене {cost}";
            }

        }

        Price[] prices;

        public PriceTable()
        {
            prices = new Price[3];
        }

        public void FillData()
        {
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("Введите товар");
                string name = Console.ReadLine();
                Console.WriteLine("Введите магазин");
                string shopName = Console.ReadLine();
                Console.WriteLine("Введите цену");
                uint? cost;
                while (true)
                {
                    try
                    {
                        cost = Convert.ToUInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Цена введена неправильно. Попробуйте еще раз.");
                    }
                }
                prices[i] = new Price(name, shopName, cost);

            }

            prices = prices.OrderBy(i => i.ShopName).ToArray();
        }

        public void PrintData()
        {
            foreach(var price in prices)
            {
                Console.WriteLine(price);
            }
        }

        public string this[string shopName]
        {
            get
            {
                string answer = "";
                for (int i = 0; i < prices.Length; i++)
                {
                    if (shopName == prices[i].ShopName)
                    {
                        answer += prices[i] + "\n";
                    }
                }
                if (answer.Length == 0)
                {
                    return "Товары введенного магазина не найдены";
                }
                return answer;
            }
        }
    }
}
