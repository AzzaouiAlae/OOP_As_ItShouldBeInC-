using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25___Multiple_Interfaces
{
    public interface IPerson
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        void Introduce();
        void Print();
        void To_String();
    }

    public interface ICommunication
    {
        void CallPhone();
        void SendEmail(string Title, string Body);
        void SendSMS(string Title, string Body);
        void SendFax(string Title, string Body);
    }

    public abstract class Person : IPerson, ICommunication
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string FullName()
        {
            return Firstname + " " + Lastname;
        }
        public abstract void Introduce();
        
        public void Print()
        {
            Console.WriteLine("This is the print method");
        }
        public void To_String()
        {
            Console.WriteLine($"Firstname : {Firstname}   Lastname : {Lastname}");
        }
        public void CallPhone()
        {
            Console.WriteLine("this is Call Phone Method");
        }
        public void SendEmail(string Title, string Body)
        {
            Console.WriteLine($"{Title}\n{Body}\n");
        }
        public void SendSMS(string Title, string Body)
        {
            Console.WriteLine($"{Title}\n{Body}\n");
        }
        public void SendFax(string Title, string Body)
        {
            Console.WriteLine($"{Title}\n{Body}\n");
        }
    }

    public class Employees : Person
    {
        public int ID { get; set; }
        public override void Introduce()
        {
            Console.WriteLine("Hello i'm " + FullName() + " and my ID number is " + ID);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees Emp1 = new Employees();
            Emp1.Firstname = "Alae";
            Emp1.Lastname = "Azzaoui";
            Emp1.Introduce();
            Emp1.Print();
            Emp1.To_String();
            Emp1.CallPhone();
            Emp1.SendEmail("Email Title", "Email Mesg");
            Emp1.SendSMS("SMS Title", "SMS Mesg");
            Emp1.SendSMS("Fax Title", "Fax Mesg");

            Console.ReadLine();

        }
    }
}
