using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Document[] documents = new Document[3];
            documents[0] = new Title() { Content = "dawda" };
            documents[1] = new Body() { Content = "adad" };
            documents[2] = new Footer();
            foreach (var doc in documents)
            {
                doc.Show();
            }
            Console.ReadKey();
        }
    }
}
