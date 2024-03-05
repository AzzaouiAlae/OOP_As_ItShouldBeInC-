using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Static_Members
{

    class clsA
    {
        public int x;
        public static int y;

        public int Fun1()
        {
            return x * 10;
        }

        public static int Fun2()
        {
            return y * 10;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsA A = new clsA();
            A.x = 10;
            clsA.y = 20;

            Console.WriteLine("A.x = " + A.x);
            Console.WriteLine("A.Fun1 = " + A.Fun1() + "\n");

            Console.WriteLine("clsA.y = " + clsA.y);
            Console.WriteLine("clsA.Fun2 = " + clsA.Fun2() + "\n");
            Console.ReadKey();
        }
    }
}
