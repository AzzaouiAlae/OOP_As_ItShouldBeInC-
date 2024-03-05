using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _12___Multiple_Constructors_using_overloading
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
            Age = 30;
        }

        public clsPersons(int ID, string Name, int Age)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPersons Person1 = new clsPersons();
            Console.WriteLine(Person1.ID);
            Console.WriteLine(Person1.Name);
            Console.WriteLine(Person1.Age + "\n");

            clsPersons Person2 = new clsPersons(5, "Alae Azzaoui", 50);
            Console.WriteLine(Person2.ID);
            Console.WriteLine(Person2.Name);
            Console.WriteLine(Person2.Age);

            Console.ReadKey();
        }
    }
}
