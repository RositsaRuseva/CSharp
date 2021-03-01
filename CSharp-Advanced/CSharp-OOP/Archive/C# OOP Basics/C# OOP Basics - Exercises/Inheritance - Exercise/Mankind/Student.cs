using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstname, string lastname, string facultyNumber)
            : base(firstname, lastname)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Length < 5 ||
                    value.Length > 10 ||
                    !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Faculty number: {FacultyNumber}\n";
        }
    }
}
