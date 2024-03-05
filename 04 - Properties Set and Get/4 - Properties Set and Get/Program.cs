using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Properties_Set_and_Get
{
    class clsPerson
    {
        private int _ID;
        private string _Name;

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }
            set 
            { 
                _Name = value; 
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person1 = new clsPerson();
            Person1.ID = 1;
            Person1.Name = "Alae Azzaoui";

            Console.WriteLine("ID   : " + Person1.ID);
            Console.WriteLine("Name : " + Person1.Name);

            Console.ReadKey();
        }
    }
}
