using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPlanner.ConsoleUI
{
    //Every Person should always have a first name and a surname
    // a surname prefix is optional
    internal class Person
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

        public string FullName { 
            get {
                return GetFullName();
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

        protected virtual string GetFullName() 
        {
            return $"{this.FirstName} {(this.SurnamePrefix + " " ).TrimStart() +  this.Surname}";
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + this.GetFullName();
        }
    }
}
