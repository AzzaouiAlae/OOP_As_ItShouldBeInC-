using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24___Interface
{
    public interface IPersons
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        void SayGoodBye();
        void Print();
        string To_String();
    }

    public class Employees : IPersons
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public void SayGoodBye()
        {
            Console.WriteLine("GoodBye!");
        }

        public void Print()
        {
            Console.WriteLine("This is Print method");
        }

        public string To_String()
        {
            return "This is a string to return";
        }

        public string FullName()
        {
            return Firstname + " " + Lastname;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            employees.Firstname = "Alae";
            employees.Lastname = "Azzaoui";
            Console.WriteLine(employees.FullName());
            employees.To_String();
            employees.SayGoodBye();
            Console.ReadLine();
        }
    }
}
