using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Human
    {

        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: firstName");
                }
                else if (value.Length < 4)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: firstName");
                }
                
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set

            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: lastName");
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName");
                }
                
                this.lastName = value;
            }
        }

        public Human(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\n";
        }
    }
}
