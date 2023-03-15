using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_App
{
    internal class Person
    {
        //Declare a field to represent personality
        private string personality;

        // Constructor
        public Person()
        {
            personality = "Mystery";
        }

        public void AskQuestion(int answer)
        {
            if (answer == 1) 
            {
                personality = "Extrovert";
            }
            else
            {
                personality = "Introvert";
            }
        }

        //This METHOD returns the value of "personality"
        public string GetPersonality()
        {
            return personality;
        }
    }
}
