using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___App.Static_and_Constructors
{
    class clsPerssons
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public clsPerssons(int ID, string Name, int Age)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }

        static public clsPerssons Find (int ID)
        {
            if(ID == 10)
            {
                return new clsPerssons(10, "Alae Azzaoui", 30);
            }
            else
            return null;
        }
        static public clsPerssons Find(string Username, string Password)
        {
            if (Username == "azzaoui2" && Password == "alae123")
            {
                return new clsPerssons(10, "Alae Azzaoui", 30);
            }
            else
                return null;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerssons P1 = new clsPerssons(5, "Oussama azzaoui", 31);
            Console.WriteLine("ID   = " + P1.ID);
            Console.WriteLine("Name = " + P1.Name);
            Console.WriteLine("Age  = " + P1.Age + "\n");

            clsPerssons P2 = clsPerssons.Find(10);
            if(P2 != null)
            {
                Console.WriteLine("ID   = " + P2.ID);
                Console.WriteLine("Name = " + P2.Name);
                Console.WriteLine("Age  = " + P2.Age + "\n");
            }            

            clsPerssons P3 = clsPerssons.Find("azzaoui2", "alae123");
            if(P3 != null)
            {
                Console.WriteLine("ID   = " + P3.ID);
                Console.WriteLine("Name = " + P3.Name);
                Console.WriteLine("Age  = " + P3.Age + "\n");
            }            
            Console.ReadLine();
        }
    }
}
