using System;
using System.IO;
using ClassLibrary1;

namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 C  = new Class1();
            Console.WriteLine(C.Sum(10, 20));

            Console.WriteLine(C.Sum(10, 20, 30));

            Console.ReadLine();
        }
    }
}
