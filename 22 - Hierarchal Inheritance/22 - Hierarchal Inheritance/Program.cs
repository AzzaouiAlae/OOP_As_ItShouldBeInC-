using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Hierarchal_Inheritance
{
    class clsPersons
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} and i am {Age} years old");
        }
    }
    class clsEmployees : clsPersons
    {
        public int ID { get; set; }
        public decimal Salary { get; set; }
        public void Work()
        {
            Console.WriteLine($"Employee with ID {ID} and salary {Salary} is working");
        }
    }
    class clsUser : clsPersons
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public void Info ()
        {
            Console.WriteLine($"Username : {UserName} and Password : {Password}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployees employee = new clsEmployees();
            employee.Name = "Alae";
            employee.Age = 30;
            employee.ID = 1;
            employee.Salary = 4000;
            employee.Introduce();
            employee.Work();

            Console.ReadLine();

            clsUser User = new clsUser();
            User.Name = "Alae Azzaoui";
            User.Age = 30;
            User.UserName = "azzaoui";
            User.Password = "alae123";
            User.Introduce();
            User.Info();

            Console.ReadLine();
        }
    }
}
