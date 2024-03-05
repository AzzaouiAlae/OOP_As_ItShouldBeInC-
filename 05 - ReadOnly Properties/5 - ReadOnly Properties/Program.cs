using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___ReadOnly_Properties
{
    class clsPersons
    {
        int _ID;
        string _Name;
        public clsPersons(int id, string Name = "")
        {
            _ID = id;
            _Name = Name;
        }
        public int ID
        {
            get { return _ID; }
        }

        public string Name
        { 
            get { return _Name;}
            set { _Name = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPersons Person1 = new clsPersons(1, "Alae Azzaoui");
            Console.WriteLine(Person1.ID);
            Console.WriteLine(Person1.Name + "\n");

            clsPersons Person2 = new clsPersons(2, "Oussama Azzaoui");
            Console.WriteLine(Person2.ID);
            Console.WriteLine(Person2.Name);

            Console.ReadKey();
        }
    }
}
