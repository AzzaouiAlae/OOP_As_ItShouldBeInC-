using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Calculator_Project
{
    class clsCalculator
    {
        int _Num;
        string _LastOperation;

        public void Add(int num)
        {
            _Num += num;
            _LastOperation = $"Result after adding {num} is : {_Num}";
        }

        public void Sub(int num)
        {
            _Num -= num;
            _LastOperation = $"Result after subtracting {num} is : {_Num}";
        }

        public void Multiply(int num)
        {
            _Num *= num;
            _LastOperation = $"Result after multiplying {num} is : {_Num}";
        }

        public void Divid(int num)
        {
            if (!(num == 0 || _Num == 0))
                _Num /= num;

            _LastOperation = $"Result after dividing {num} is : {_Num}";
        }

        public void Clear()
        {
            _Num = 0;
            _LastOperation = $"Result after Clear is : {_Num}";
        }

        public void PrintResult()
        {
            Console.WriteLine(_LastOperation);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculator Calculator1 = new clsCalculator();

            Calculator1.Add(10);
            Calculator1.PrintResult();

            Calculator1.Add(100);
            Calculator1.PrintResult();

            Calculator1.Sub(20);
            Calculator1.PrintResult();

            Calculator1.Divid(0);
            Calculator1.PrintResult();

            Calculator1.Divid(2);
            Calculator1.PrintResult();

            Calculator1.Multiply(3);
            Calculator1.PrintResult();

            Calculator1.Clear();
            Calculator1.PrintResult();

            Console.ReadLine();
        }
    }
}
