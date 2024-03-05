using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31___Partial_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 29;
            p.BirthDay();
            Console.ReadLine();
        }
    }
}
