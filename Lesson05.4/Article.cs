using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._4
{
    class Article
    {
        string articleName, shopName;        
        double cost;
        

        public Article(string articleName, string shopName, double cost)
        {
            this.articleName = articleName;
            this.cost = cost;
            this.shopName = shopName;
        }

        public string ArticleName { get { return articleName; } }
        public string ShopName { get { return shopName; } }
        public double Cost { get { return cost; } }
    }
}
