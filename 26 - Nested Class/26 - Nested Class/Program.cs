using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26___Nested_Class
{
    public class OuterClass
    {
        private int OuterVariable;
        
        public OuterClass(int outerVariable) 
        { 
            OuterVariable = outerVariable; 
        }
        public void OuterMethod()
        {
            Console.WriteLine($"This is OuterMethod and OuterVariable is {OuterVariable}");
        }
        public class InnerClass
        {
            private int InnerVariable;
            public InnerClass(int innerVariable)
            {
                InnerVariable = innerVariable;
            }
            public void InnerMethod()
            {
                Console.WriteLine($"This is InnerMethod and InnerVariable is {InnerVariable}");
            }

            public void AccessOuterClass(OuterClass Outer)
            {
                Console.WriteLine($"This is AccessOuterClass Method and OuterVariable is {Outer.OuterVariable}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OuterClass Outer = new OuterClass(30);
            Outer.OuterMethod();
            Console.ReadLine();

            OuterClass.InnerClass Inner = new OuterClass.InnerClass(100);
            Inner.InnerMethod();
            Console.ReadLine();
            Inner.AccessOuterClass(Outer);
            Console.ReadLine();
        }
    }
}
