using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02._04
{
    class Invoice
    {
        readonly int account;
        readonly string customer, provider;

        public int Quantity { get; set; }
        public string Article { get; set; }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void CalculateCost()
        {
            double cost, costWithNds;
            switch(Article.ToLower())
            {
                case "iphone":
                    cost = 12 * Quantity;
                    break;
                default:
                    Console.WriteLine("Error! Not info about article");
                    return;
            }
            costWithNds = cost * 7 / 6;
            Console.WriteLine($"Стоимость с ндс {costWithNds} без ндс {cost}");
        }
    }
}
