using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___Overriding__Inheritance__Base
{
    public class clsA
    {
        public virtual void Print()
        {
            Console.WriteLine("This is Class A");
        }
    }

    public class clsB : clsA
    {
        public override void Print()
        {
            Console.WriteLine("This is Class B");
            Console.ReadLine();
            base.Print();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsB cls_B = new clsB();

            cls_B.Print();
            Console.ReadLine();
        }
    }
}
