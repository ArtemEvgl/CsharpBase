using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Apartment = 2;
            address.City = "Kursk";
            address.Country = "Russia";
            address.House = 2;
            address.Index = 305007;
            address.Street = "Sum";
            Console.WriteLine($"{address.Country} {address.City} {address.Street}" +
                                $" {address.House} {address.Apartment} {address.Index}");
            Console.ReadKey();
        }
    }
}
