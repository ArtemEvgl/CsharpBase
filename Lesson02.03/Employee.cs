using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02._03
{
    class Employee
    {
        readonly string name, surname;
        int experience;
        string post;

        public string Name
        {
            get
            {
                if(name == null)
                {
                    return "Поле не введено";
                }
                return name;
            }            
        }

        public string Surname
        {
            get
            {
                if (surname == null)
                {
                    return "Поле не введено";
                }
                return surname;
            }
        }

        public string Post
        {
            get
            {
                if(post==null)
                {
                    return "Поле не введено";
                }
                return post;
            }
            set
            {
                if(value != null)
                {
                    post = value;
                }
            }
        }

        public int Experience
        {
            get
            {                
                return experience;
            }

            set
            {
                if(value >= 0)
                {
                    experience = value;
                }
            }
        }

        public Employee ()
        {

        }

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        

        private double CalculateSalary()
        {
            double salary;
            switch (post.ToLower())
            {
                case "manager":
                    salary = 500;
                    break;
                case "dev":
                    salary = 1500;
                    break;
                case "boss":
                    salary = 5000;
                    break;
                default:
                    salary = 100;
                    break;
            }

            switch(experience)
            {
                case 5:
                    salary *= 1.5;
                    break;
                case 2:
                    salary *= 1.2;
                    break;
                case 1:
                    salary *= 1.1;
                    break;
            }

            return salary;
        }

        public void ShowSalary()
        {
            Console.WriteLine($"Зарплата {CalculateSalary()}, подоходный налог {CalculateSalary() * 0.13}");
        }
    }
}
