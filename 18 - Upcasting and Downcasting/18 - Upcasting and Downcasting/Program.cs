using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Upcasting_and_Downcasting
{
    public class clsPersons
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Greet()
        {
            Console.WriteLine($"Hi, My name is {Name} and i am {Age} years old");
        }
    }
    public class clsEmployees : clsPersons
    {
        

        public string Company { get; set; }
        public decimal Salary { get; set; }

        public void Work()
        {
            Console.WriteLine($"I work at {Company} and earn {Salary:C} per year");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployees Emp1 = new clsEmployees { Name = "Alae Azzaoui", Age = 30, Company = "TopoSystemes", Salary = 4000};
            clsPersons persons1 = Emp1;
            persons1.Greet();

            clsPersons persons2 = new clsEmployees { Name = "Salwa Azzaoui", Age = 34, Company = "WebHelp", Salary = 6000 };
            clsEmployees Emp2 = (clsEmployees)persons2;
            persons2.Greet();
            Console.ReadLine();

            clsPersons persons3 = new clsPersons();
            clsEmployees Emp3 = (clsEmployees)persons3;
            Console.ReadLine();
        }
    }
}
