using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace MyProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 C  = new Class1();
            Console.WriteLine(C.Sum(10, 20).ToString());
            Console.WriteLine(C.Sum(10, 20, 30).ToString());
            Console.ReadLine();
        }
    }
}
