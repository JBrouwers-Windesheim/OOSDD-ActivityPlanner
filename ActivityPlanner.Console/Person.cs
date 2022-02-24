using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPlanner.ConsoleUI
{
    internal abstract class Person
    {
        #region Properties
        public string FirstName { get; set; }

        public string SurnamePrefix { get; set; }

        private string _surname;//private field => data container
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        #endregion

        #region Constructors

        public Person(string firstname, string surname)
        {
            this.FirstName = firstname;
            this.Surname = surname;
        }

        #endregion

    }
}
