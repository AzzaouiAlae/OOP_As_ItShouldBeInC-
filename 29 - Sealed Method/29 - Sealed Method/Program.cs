using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29___Sealed_Method
{
    class clsPersons
    {
        public virtual void Greet()
        {
            Console.WriteLine("The Person says hello");
        }
    }

    class clsEmployees : clsPersons
    {
        sealed public override void Greet()
        {
            Console.WriteLine("The Employee Greet you!");
        }
    }

    class clsManagers : clsEmployees
    {
        //public override void Greet()
        //{
        //    Console.WriteLine("The Employee Greet you!");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPersons P = new clsPersons();
            P.Greet();
            Console.ReadLine();

            clsEmployees Emp = new clsEmployees();
            Emp.Greet();
            Console.ReadLine();

            clsManagers Manager = new clsManagers();
            Manager.Greet();
            Console.ReadLine();

        }
    }
}
