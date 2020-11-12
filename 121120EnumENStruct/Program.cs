using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _121120EnumENStruct
{

    public enum Subjects
    { 
            Csharp,                 //Primitieve datatypes    (valuetypes)        (array is reference type))                   
            Java,       
            Networking,
            Taal
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef naam van student aub: ");
                string name = Console.ReadLine();

            Console.WriteLine("Geef leeftijd van student aub: ");
            int age = int.Parse(Console.ReadLine());

            // Subjects subjects = Subjects.Networking;               //Manier 1
            Console.WriteLine("Geef aan welke richting: ");            //Manier 2
            int subjects = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter email adres:");
            string email = Console.ReadLine();
            
            Console.WriteLine("-----------------------------");
            //Student student = new Student(name, age, subjects);       //Hoort bij Manier 1
            Student student = new Student(name, age,(Subjects)subjects, email);//Hoort bij Manier 2 (casting subjects)
            student.PrintStudentIfo();
        }
    }
    public struct Student               // is een container van data
    {
        public string Name;             //Fields
        public int Age;                 //Fields
        public Subjects Subject;        //Fields
        public string Email;            //Fields

        public Student(string name, int age, Subjects subjects, string email)            //CONTRUCT soort methode maar geeft geen return
        {
            Name = name;
            Age = age;
            Subject = subjects;
            Email = email;
        }

        public void PrintStudentIfo()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Age);
            Console.WriteLine(this.Subject);
            Console.WriteLine(this.Email);
        }
    }
}
