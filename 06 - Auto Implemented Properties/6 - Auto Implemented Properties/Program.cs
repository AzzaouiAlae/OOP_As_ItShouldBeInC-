using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Auto_Implemented_Properties
{
    class clsEmployees
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployees Emp = new clsEmployees();
            Emp.ID = 1;
            Emp.Name = "Alae Azzaoui";
            Console.WriteLine(Emp.ID);
            Console.WriteLine(Emp.Name + "\n");


            clsEmployees Emp1 = new clsEmployees();
            Emp1.ID = 2;
            Emp1.Name = "Oussama Azzaoui";
            Console.WriteLine(Emp1.ID);
            Console.WriteLine(Emp1.Name);

            Console.ReadKey();
        }
    }
}
