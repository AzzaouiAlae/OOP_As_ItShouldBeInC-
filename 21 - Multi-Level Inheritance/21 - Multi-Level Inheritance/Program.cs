using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___Multi_Level_Inheritance
{
    class clsPersons
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hi, My name is {Name} and i am {Age} years old.");
        }
    }
    class clsEmployees : clsPersons
    {
        public int ID { get; set; }
        public decimal Salary { get; set; }
        public void Work()
        {
            Console.WriteLine($"Employee with ID {ID} and salary {Salary} is working");
        }
    }
    class clsDoctor : clsEmployees
    {
        public string Specialty { get; set; }
        public void Heal()
        {
            Console.WriteLine($"Doctor {Name}, With ID {ID}, and Salary {Salary}, and specialty {Specialty} is healing a patient");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsDoctor doctor = new clsDoctor();
            doctor.Name = "John";
            doctor.Age = 30;
            doctor.ID = 1;
            doctor.Salary = 4000;
            doctor.Specialty = "Cardiology";
            doctor.Introduce();
            doctor.Work();
            doctor.Heal();

            Console.ReadLine();
        }
    }
}
