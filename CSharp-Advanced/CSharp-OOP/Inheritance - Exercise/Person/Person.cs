using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.name, this.age));

            // return stringBuilder.ToString();
            return $"Name: {this.name}, Age: {this.age}";
        }
    }
}
