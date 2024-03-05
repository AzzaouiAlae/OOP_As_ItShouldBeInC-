using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Static_Properties___Static_Class
{
    static class Settings
    {
        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static int DayNum
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string ProjectPath
        {
            get;
            set;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Settings.DayNum);
            Console.WriteLine(Settings.DayName);
            Settings.ProjectPath = @"C:\MyProject\";
            Console.WriteLine(Settings.ProjectPath);
            Console.ReadLine();
        }
    }
}
