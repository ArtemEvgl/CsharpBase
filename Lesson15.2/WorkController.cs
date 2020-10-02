using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15._2
{
    class WorkController
    {
        Worker[] workers;

        public WorkController()
        {
            workers = new Worker[3];
        }

        public void FillData()
        {
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine("Enter name worker:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter position:");
                string position = Console.ReadLine();
                Console.WriteLine("Enter admission:");
                string date = Console.ReadLine();
                DateTime dateTime;
                while (true)
                {
                    try
                    {
                        dateTime = DateTime.Parse(date);
                        break;
                    }
                    catch (FormatException e)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error date. Please try again");
                        Console.ResetColor();
                    }
                }
                workers[i] = new Worker(name, position, dateTime);
            }
            workers = workers.OrderBy(i => i.Name).ToArray();
        }

        public void PrintWorkers()
        {
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }
        }

        

        public string this[int year]
        {
            get
            {
                string answer = "";
                for (int i = 0; i < workers.Length; i++)
                {
                    if (workers[i].Experience > year)
                        answer += workers[i] + "\n";
                }
                if (answer.Length >= 0)
                    return answer;
                return "нет сотрудников с таки стажем работы";
            }
        }

    }
}
