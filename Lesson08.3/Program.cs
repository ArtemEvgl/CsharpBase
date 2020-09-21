using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08._3
{

    enum Post
    {
        Boss = 10,
        Developer = 40,
        Manager = 80,
        Security = 120
    }
    class Accauntant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            return (int)worker < hours;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter post:");           
            string post = Console.ReadLine().ToLower();
            int workHours;
            while (true)
            {
                Console.WriteLine("Enter work hours:");
                if (int.TryParse(Console.ReadLine(), out workHours))
                    break;
                else
                    Console.WriteLine("Input data is incorrect. Please try again");
            }                        
            Post worker = (Post)Enum.Parse(typeof(Post), post, true);
            bool bonusResult = Accauntant.AskForBonus(worker, workHours);
            if(bonusResult)
            {
                Console.WriteLine("BONUS!!! LUCKY CHEAL!");
            } else
            {
                Console.WriteLine("No Bonus. No money, no honey");
            }
            Console.ReadKey();
        }
    }
}
