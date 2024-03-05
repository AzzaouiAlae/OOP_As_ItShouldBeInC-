using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___Method_Hiding
{
    class BaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base Class Method1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Base Class Method2");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Method1()
        {
            Console.WriteLine("Derived Class Method1");
        }
        public new void Method2()
        {
            Console.WriteLine("Derived Class Method2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            bc.Method1();
            bc.Method2();
            Console.ReadKey();

            DerivedClass dc = new DerivedClass();
            dc.Method1();
            dc.Method2();
            Console.ReadKey();

            BaseClass bcCastring = new DerivedClass();
            bcCastring.Method1();
            bcCastring.Method2();
            Console.ReadKey();

        }
    }
}
