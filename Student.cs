using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_App
{
    //Here we can only read or write data to this class
    internal class Student : Person
    {
        //Private field (backing field) to hold any data assigned Name property.
        private string _name;

        private Student() 
        {
            _name = "";
        }

        //this is the Name property
        public string Name
        {
            get { return _name; }  //use Get accessor to read data from the class
            set { _name = value; } //Set accessor value is set automatically 
        }

    }
}
