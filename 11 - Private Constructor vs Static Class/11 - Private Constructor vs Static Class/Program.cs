using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Private_Constructor_vs_Static_Class
{

    class clsSetting
    {
        static public int DayNum
        {
            get { return DateTime.Today.Day; }
        }

        static public string DayName
        {
            get { return DateTime.Today.DayOfWeek.ToString(); }
        }

        static public string ProjectPath
        {
            get;
            set;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsSetting.ProjectPath = @"c:\MyProjects\";

            Console.WriteLine("DayNum      = " + clsSetting.DayNum);
            Console.WriteLine("DayName     = " + clsSetting.DayName);
            Console.WriteLine("ProjectPath = " + clsSetting.ProjectPath);

            Console.ReadLine();
        }
    }
}
