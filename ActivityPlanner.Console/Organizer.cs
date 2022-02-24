using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPlanner.ConsoleUI
{
    internal class Organizer: Person
    {
        public Organizer(string firstname, string surname)
            : base(firstname, surname)
        {
        }
        public Organizer(): this(string.Empty, string.Empty)
        {

        }
    }
}
