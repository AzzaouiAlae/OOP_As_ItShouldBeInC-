using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Access_Modifiers
{
    class clsA
    {
        public int x1 = 10;
        private int x2 = 20;
        protected int x3 = 30;

        public int Fun1()
        {
            return 100;
        }
        private int Fun2()
        {
            return 200;
        }
        protected int Fun3()
        {
            return 300;
        }
    }

    class clsB : clsA
    {
        public int Fun4()
        {
            return Fun3();
        }

        public int Fun5()
        {
            return x3;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsA A = new clsA();
            Console.WriteLine("x1 = " + A.x1);
            Console.WriteLine("Fun1 = " + A.Fun1() + "\n");

            clsB B = new clsB();
            Console.WriteLine("Fun4 = " + B.Fun4());
            Console.WriteLine("Fun5 = " + B.Fun5());

            Console.ReadLine();
        }
        
    }
}
