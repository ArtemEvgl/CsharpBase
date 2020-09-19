using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter your birthday:");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime nextBirhDate))
                {
                    nextBirhDate = nextBirhDate.AddYears(DateTime.Now.Year - nextBirhDate.Year);
                    TimeSpan timeSpanBeforeBirhday = nextBirhDate - DateTime.Now;
                    Console.WriteLine($"left until your birthday {Math.Round(timeSpanBeforeBirhday.TotalDays)} days");
                    break;
                }
                else
                {
                    Console.WriteLine("The date of birth format you entered is not supported. Please try again.");
                }
            }
            Console.ReadKey();            
        }

    }
}
