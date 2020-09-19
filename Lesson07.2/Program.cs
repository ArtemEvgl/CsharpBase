using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            a ^= b ^= a ^= b;
            Train[] trains = new Train[8];
            while (true)
            {
                int freePosition = trains.Where(train => train.Destination == null).Count();
                int index = trains.Length - freePosition;
                PrintMenu(trains, freePosition);
                string itemMenu = Console.ReadLine();
                switch (itemMenu)
                {
                    case "1":
                        AddTrain(index, trains);
                        break;
                    case "2":
                        DeleteTrain(index, trains);
                        break;
                    case "3":
                        GetInfoAboutTrain(trains);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                        continue;
                }
            }
        }

        private static void PrintMenu(Train[] trains, int freePosition)
        {
            Console.WriteLine("Выберите пункт меню");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine($"Свободных позиций - {freePosition}");
            Console.WriteLine($"1. Добавить поезд.");
            Console.WriteLine($"2. Удалить поезд.");
            Console.WriteLine($"3. Получить информацию о поезде.");            
            Console.WriteLine($"4. Выход");
        }

        private static void AddTrain(int index, Train[] trains)
        {
            Console.WriteLine("Введите пункт назначения");
            string destination = Console.ReadLine();
            Console.WriteLine("Введите дату отправления");
            string dateTime = Console.ReadLine();
            Console.WriteLine("Введите номер поезда");
            int number = Convert.ToInt32(Console.ReadLine());
            Train train = new Train(destination, dateTime, number);
            trains[index] = train;
            Console.WriteLine("Поезд успешно добавлен");
        }

        private static void DeleteTrain(int index, Train[] trains)
        {
            Console.WriteLine("Введите номер поезда который хотите удалить: ");
            int numberTrain = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < trains.Length; i++)
            {
                if(trains[i].Number == numberTrain)
                {                   
                    OptimiziationMassive(i, index, trains);
                }
            }
            Console.WriteLine("Поезд успешно удален.");
        }

        private static void OptimiziationMassive(int i, int index, Train[] trains)
        {
            int lastPositionTrainNotNull = index - 1;
            if(i < lastPositionTrainNotNull)
            {
                trains[i] = trains[lastPositionTrainNotNull];
                trains[lastPositionTrainNotNull] = new Train();
            } 
            else
            {
                trains[i] = new Train();
            }
        }

        public static void GetInfoAboutTrain(Train[] trains)
        {
            Console.WriteLine("Введите номер поезда о котором хотите получить информацию: ");
            int numberTrain = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].Number == numberTrain)
                {
                    trains[i].ShowTrainInfo();
                }
            }
        }

    }
}
