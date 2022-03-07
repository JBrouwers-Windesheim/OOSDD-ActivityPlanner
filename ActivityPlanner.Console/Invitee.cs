using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPlanner.ConsoleUI
{
    internal class Invitee: Person
    {
        public Invitee(string firstName, string surname)
            :base(firstName, surname)
        {

        }

        protected override string GetFullName()
        {
            //maak een vergelijkbare oplossing maar dan met de stringbuilder classe

            //eerst tussenvoegsels, dan achtenaam, dan komma, dan voornaam
            return (this.SurnamePrefix + " ").TrimStart() + $"{this.Surname}, {this.FirstName}";
        }

        
    }
}
