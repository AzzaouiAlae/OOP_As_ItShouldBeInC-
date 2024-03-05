using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _23___Abstract_Class___Methods
{
    abstract class clsPerson
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public abstract void Introduce();
        public void SayGoodBye()
        {
            Console.WriteLine("GoodBye!");
        }        
    }

    class clsEmployees : clsPerson 
    {
        public int ID { get; set; }
        public override void Introduce()
        {           
            Console.WriteLine($"Hi My name is {Firstname} {Lastname}, and my employee ID is {ID}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //clsPerson p = new clsPerson();

            clsEmployees Emp1 = new clsEmployees();
            Emp1.Firstname = "Alae";
            Emp1.Lastname = "Azzaoui";
            Emp1.ID = 10;

            Emp1.Introduce();
            Emp1.SayGoodBye();
            Console.ReadKey();
        }
    }
}
