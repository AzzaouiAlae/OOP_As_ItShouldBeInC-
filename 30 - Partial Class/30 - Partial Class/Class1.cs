using System;

namespace _30___Partial_Class
{
    public partial interface IPerson
    {
        string Firstname { get; set;}
    }
    public partial class MyClass : IPerson
    {
        public string Firstname { get; set;} 
        public void Method1()
        {
            Console.WriteLine("Hello this is Method1");
        }
    }
}
