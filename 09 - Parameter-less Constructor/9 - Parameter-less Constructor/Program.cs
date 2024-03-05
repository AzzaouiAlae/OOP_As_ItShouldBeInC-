using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Parameter_less_Constructor
{
    class clsPersons
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public clsPersons() 
        {
            ID = -1;
            Name = "Empty";
            Age = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPersons Person1 = new clsPersons();

            Console.WriteLine("ID   = {0}", Person1.ID);
            Console.WriteLine("Name = {0}", Person1.Name);
            Console.WriteLine("Age  = {0}", Person1.Age);
            Console.ReadKey();
        }
    }
}
