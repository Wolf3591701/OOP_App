using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_App
{
    internal abstract class Program
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Console.WriteLine("Type 1 if you like to mingle and chat with people, or 2 if you're the opposite: ");
        //        string input = Console.ReadLine();
        //        Person myPerson = new Person();
        //        myPerson.AskQuestion(int.Parse(input));
        //        Console.WriteLine("You are: " + myPerson.GetPersonality());
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Please type numbers 1 or 2");
        //    }

            class ProgramMain : Student
            {
            // Constructor
            public ProgramMain(string name, int age, string grade) : base(name, age, grade)
            {
            }

            static void Main(string[] args)
            {
                // Create a List of Student objects
                List<Student> students = new List<Student>();

                // Add new Student objects to the List
                students.Add(new Student("Ivan Ivanovic", 18, "5"));
                students.Add(new Student("Marko Markovic", 19, "3"));
                students.Add(new Student("Lora Loric", 17, "4"));

                // Use a foreach loop to access and display the properties of each Student object in the List
                foreach (Student student in students)
                {
                    Console.WriteLine("------------STUDENT---------------");
                    Console.WriteLine("Student Name: " + student.Name);
                    Console.WriteLine("Student Age: " + student.Age);
                    Console.WriteLine("Student Grade: " + student.Grade + "\n");
                }

                Console.ReadLine();
            }
        }
    }
}

