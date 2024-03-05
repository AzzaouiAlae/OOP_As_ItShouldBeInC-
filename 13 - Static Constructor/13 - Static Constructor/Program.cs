using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Static_Constructor
{
    class clsSetting
    {
        static public int DayNum
        {
            get { return DateTime.Today.Day; }
        }
        static clsSetting()
        {
            Console.WriteLine("This is static constructor");
            Console.ReadKey();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(clsSetting.DayNum);
            Console.ReadKey();
        }
    }
}
