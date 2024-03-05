using System;

namespace _30___Partial_Class
{
    public partial interface IPerson
    {
        string Lastname { get; set; }
    }
    public partial class MyClass 
    {
        public string Lastname { get; set; }
        public void Method2()
        {
            Console.WriteLine("Hello this is Method2");
        }
    }
}
