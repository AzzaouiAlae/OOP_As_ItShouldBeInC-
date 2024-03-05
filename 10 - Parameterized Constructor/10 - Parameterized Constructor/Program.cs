using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Parameterized_Constructor
{
    class clsPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public clsPerson(int ID, string Name, int Age)
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
            clsPerson P1 = new clsPerson(1, "Alae Azzaoui", 30);

            Console.WriteLine("ID   = {0}", P1.ID);
            Console.WriteLine("Name = {0}", P1.Name);
            Console.WriteLine("Age  = {0}", P1.Age);

            Console.ReadKey();
        }
    }
}
