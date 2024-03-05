using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Class___Object
{
    class clsPerson
    {
        public string FirstName;
        public string LastName;

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person1 = new clsPerson();
            Person1.FirstName = "Alae";
            Person1.LastName = "Azzaoui";
            Console.WriteLine("Person1 Name");
            Console.WriteLine(Person1.FullName() + "\n");


            clsPerson Person2 = new clsPerson();
            Person1.FirstName = "Salwa";
            Person1.LastName = "Azzaoui";
            Console.WriteLine("Person2 Name");
            Console.WriteLine(Person1.FullName() + "\n");

            Console.ReadKey();
        }
    }
}
