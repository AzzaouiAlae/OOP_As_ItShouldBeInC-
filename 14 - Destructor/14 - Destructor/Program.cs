using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Destructor
{
    class clsPerssons
    {
        public clsPerssons() 
        {
            Console.WriteLine("This is Constructor");
            Console.ReadLine();
        }

        ~clsPerssons()
        {
            Console.WriteLine("This is Destractor");
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {            
            clsPerssons P1 = new clsPerssons();
            
            Console.WriteLine("This is the Main");
            Console.ReadLine();
        }
    }
}
