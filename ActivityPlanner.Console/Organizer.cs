using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPlanner.ConsoleUI
{
    internal class Organizer: Person
    {
        //It's important to know in which order chained constructors are called (to this and base)
        //Place a breakpoint on this constructor and follow step by step code execution when creation an new Organizer instance
        public Organizer(string firstname, string surname)
            : base(firstname, surname)
        {
        }

        //I don't like these Empty strings, every Person should always have a first name and a surname
        public Organizer(): 
            this(string.Empty, string.Empty)
        {

        }
    }
}
