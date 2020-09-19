using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._3
{
    class Player : IPlayable, IRecodable
    {
        void IPlayable.Pause()
        {
            Console.WriteLine("Остановить музыку");
        }

        void IPlayable.Play()
        {
            Console.WriteLine("Играть музыку");
        }

        public void Stop()
        {
            Console.WriteLine("Выключить проигрыватель");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Остановить запись");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("Начать запись");
        }

        
    }
}
