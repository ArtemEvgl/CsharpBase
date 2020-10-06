using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car {Model = "Vesta", Brand = "Lada", Color= "White", Year="2019"},
                new Car {Model = "Kalina", Brand = "Lada", Color= "Blue", Year="2005"},
                new Car {Model = "X5", Brand = "BMW", Color= "White", Year="2020"},
                new Car {Model = "C4", Brand = "Mercedes", Color= "Red", Year="2015"},
            };

            var persons = new List<Person>
            {
                new Person {ModelCar = "X5", Name = "Sanchez", Phone = "2-08"},
                new Person {ModelCar = "C4", Name = "Katina", Phone = "2-28"},
                new Person {ModelCar = "Vesta", Name = "Artem", Phone = "2-33"}
            };

            var querry = from person in persons
                         join car in cars on person.ModelCar equals car.Model
                         select new
                         {
                             Name = person.Name,
                             Phone = person.Phone,
                             Brand = car.Brand,
                             Model = car.Model,
                             Color = car.Color,
                             Year = car.Year
                         };
            foreach (var item in querry)
            {
                Console.WriteLine($"{item.Name} has {item.Brand} {item.Model} {item.Color} {item.Year}");
                Console.WriteLine(new string('-', 20));
            }
            Console.ReadKey();
        }
    }
}
