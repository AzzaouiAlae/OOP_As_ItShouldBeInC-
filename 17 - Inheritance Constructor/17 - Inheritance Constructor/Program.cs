using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Inheritance_Constructor
{
    public class clsPersons
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public int Age { get; set; }
        public string FullName
        {
            get {  return Firstname + " " + Lastname; }
        }        
        public clsPersons(int id, string firstname, string lastname, string title, int age)
        {
            ID = id;
            Firstname = firstname;
            Lastname = lastname;
            Title = title;
            Age = age;
        }
    }

    public class clsEmployees : clsPersons
    {
        public clsEmployees(int id, string firstname, string lastname, string title, int age, float salary, string department) : base(id, firstname, lastname, title, age)
        {
            Salary = salary;
            Department = department;
        }
        public float Salary { get; set; }
        public string Department { get; set; }

        public void IncreaseSalary(float Amount)
        {
            Salary += Amount;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployees Emp1 = new clsEmployees(10, "Alae", "Azzaoui", "...", 30, 4000, "Topo-Dev");
            Console.WriteLine("ID         = " + Emp1.ID); 
            Console.WriteLine("Name       = " + Emp1.FullName);
            Console.WriteLine("Title      = " + Emp1.Title);
            Console.WriteLine("Age        = " + Emp1.Age);
            Console.WriteLine("Salary     = " + Emp1.Salary);
            Console.WriteLine("Department = " + Emp1.Department);
            Emp1.IncreaseSalary(500);
            Console.WriteLine("\nIncrease Salary = " + Emp1.Salary);
            Console.ReadKey();
        }
    }
}
