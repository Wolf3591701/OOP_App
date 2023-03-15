using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_App
{
    class Student
    {
        private string name;
        private int age;
        private string grade;

        public Student(string name, int age, string grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }
}

