using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09._3
{
    delegate double DelAverage(DelRandom[] delRandoms);
    delegate int DelRandom();
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            DelRandom[] delegateRandoms = new DelRandom[3];
            for (int i = 0; i < delegateRandoms.Length; i++)
            {
                delegateRandoms[i] = () =>
                {
                    int result = random.Next(20);
                    Console.WriteLine(result);
                    return result;
                };
            }

            DelAverage delAverage = (delRandoms) => (double)delRandoms.Sum(i => i.Invoke()) / (double)delRandoms.Length;

            Console.WriteLine("\n{0:##.##}",delAverage.Invoke(delegateRandoms));
            Console.ReadLine();
        }
    }
}
