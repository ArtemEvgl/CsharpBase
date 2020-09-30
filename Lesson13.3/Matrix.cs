using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson13._3
{
    class Matrix
    {
        static object locker = new object();

        const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        bool needSecond;
        Random random;
        public int Column { get; set; }
        
        public Matrix(int col, bool needSecond)
        {
            Column = col;
            random = new Random((int)DateTime.Now.Ticks);
            this.needSecond = needSecond;
        }

        private char GetChar()
        {
            return litters.ToCharArray()[random.Next(0,35)];
        }

        public void Move()
        {
            int count;
            int length;
            while (true)
            {
                count = random.Next(3,12);
                length = 0;
                Thread.Sleep(random.Next(20,5000));
                for (int i = 0; i < 40; i++)
                {
                    lock (locker)
                    {
                        Console.CursorTop = i - length;
                        Console.ForegroundColor = ConsoleColor.Black;
                        for (int j = i - length - 1; j < i; j++)
                        {
                            Console.CursorLeft = Column;
                            Console.WriteLine("█");
                        }
                        if (length < count)
                        {
                            length++;
                        }
                        else if (length == count)
                        {
                            count = 0;
                        }
                        if (needSecond && i < 20 && i > length + 2 && (random.Next(1, 5) == 3))
                        {
                            new Thread(new Matrix(Column, false).Move).Start();
                            needSecond = false;
                        }
                        if (39 - i < length)
                        {
                            length--;
                        }
                        Console.CursorTop = i - length + 1;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int j = 0; j < length - 2; j++)
                        {
                            Console.CursorLeft = Column;
                            Console.WriteLine(GetChar());
                            
                        }
                        if (length >= 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.CursorLeft = Column;
                            Console.WriteLine(GetChar());
                            
                        }
                        if (length >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.CursorLeft = Column;
                            Console.WriteLine(GetChar());
                            
                        }
                        Thread.Sleep(10);
                    }
                }
            }
        }


    }
}
