using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27___Composition
{
    class clsA
    {
        public void Method1()
        {
            Console.WriteLine("This is Method 1 of clsA");
        }

        public void Method2()
        {
            Console.WriteLine("This is Method 2 of clsA");
            Console.ReadLine();
            clsB B = new clsB();
            B.Method3();
        }
    }

    class clsB
    {
        public void Method3()
        {
            Console.WriteLine("This is Method 3 of clsB");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsA A = new clsA();
            A.Method1();
            Console.ReadLine();
            A.Method2();
            Console.ReadLine();
        }
    }
}
