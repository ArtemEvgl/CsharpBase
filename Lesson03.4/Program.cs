using System;
using System.Linq;

namespace Lesson03._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] proKeys = {"321","123" };
            string[] expertKeys = { "1234", "4321" };
            DocumentWorker worker;
            while (true)
            {
                Console.WriteLine("enter key");
                string key = Console.ReadLine();
                if (expertKeys.Contains(key))
                {
                    worker = new ExpertDocumentWorker();
                    Console.WriteLine("Expert Activate!!");
                    break;
                } else if(proKeys.Contains(key))
                {
                    worker = new ProDocumentWorker();
                    Console.WriteLine("Pro Activate!!");
                    break;
                }
                Console.WriteLine("Your key not validate! Do you want use free version?\nY/N");
                string answer = Console.ReadLine();
                if(answer.ToLower() == "Y")
                {
                    worker = new DocumentWorker();
                    Console.WriteLine("Free vesion activate!");
                    break;
                }
            }
            worker.SaveDocument();
            Console.ReadLine();
        }
    }
}
