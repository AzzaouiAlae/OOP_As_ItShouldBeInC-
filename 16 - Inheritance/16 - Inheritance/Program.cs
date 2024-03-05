using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Inheritance
{
    public class clsPerssons
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string FullName
        { 
            get { return FirstName + " " + LastName; } 
        }
    }
    public class clsEmployees : clsPerssons
    {
        public float Salary { get; set; }
        public string DepartmentName { get; set; }
        public void IncreaseSalaryBy(float Amout) 
        {
            Salary += Amout;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployees Emp1 = new clsEmployees();
            Emp1.ID = 1;
            Emp1.FirstName = "Alae";
            Emp1.LastName = "Azzaoui";
            Emp1.Title = "...";
            Emp1.Salary = 4000;
            Emp1.DepartmentName = "Topo-Dev";

            Console.WriteLine("ID              = " + Emp1.ID);
            Console.WriteLine("First name      = " + Emp1.FirstName);
            Console.WriteLine("Last name       = " + Emp1.LastName);
            Console.WriteLine("Title           = " + Emp1.Title);
            Console.WriteLine("Salary          = " + Emp1.Salary);
            Console.WriteLine("Department name = " + Emp1.DepartmentName);

            Emp1.IncreaseSalaryBy(500);
            Console.WriteLine("\nIncrease Salary By 500 = " + Emp1.Salary);

            Console.ReadKey();
        }
    }
}
