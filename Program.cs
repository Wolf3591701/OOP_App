using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_App
{
    internal abstract class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Type 1 if you like to mingle and chat with people, or 2 if you're the opposite: ");
            string input = Console.ReadLine();
            Person myPerson = new Person();
            myPerson.AskQuestion(int.Parse(input));
            Console.WriteLine("You are: " + myPerson.GetPersonality());
            }
            catch
            {
                Console.WriteLine("Please type numbers 1 or 2");
            }
        }
    }
}
