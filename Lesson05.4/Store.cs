using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._4
{
    class Store
    {
        private Article[] articles;

        public Store()
        {
            articles = new Article[3];
            articles[0] = new Article("кукуруза", "магнит", 21);
            articles[1] = new Article("бананы", "магнит", 32);
            articles[2] = new Article("огурцы", "магнит", 12);
        }

        public string this[string index] {
            get
            {
                for(int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].ArticleName == index)
                    {
                        return string.Format($"{articles[i].ArticleName} {articles[i].ShopName} {articles[i].Cost}");
                    }
                }
                return "Товар не найден";
            }      
        }

        public string this[int index]
        {
            get
            {
                return string.Format($"{articles[index].ArticleName} {articles[index].ShopName} {articles[index].Cost}");
            }
        }

    }
}
