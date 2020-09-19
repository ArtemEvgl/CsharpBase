using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._2
{
    class MyArray
    {
        int[] array;
        public MyArray(int n)
        {
            array = new int[n];
            Random random = new Random();
            for(int i = 0; i < array.Length; i++)
            {

                array[i] = random.Next(-5,5);
            }
        }

        public int Max()
        {
            int max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public int Min()
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public int Sum()
        {
            int result = 0;
            foreach(var value in array)
            {
                result += value;
            }
            return result;
        }

        public int Averrage()
        {
                        
            return Sum() / array.Length;
        }

        public void Odd()
        {
            foreach(var item in array.Where(i => i % 2 == 1))
            {
                Console.WriteLine(item);
            }
        }
    }
}
