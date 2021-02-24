using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person(10);
            person.Name = "Peter";
            person.Age = 15;

            Person secondPerson = new Person();
            secondPerson.Name = "Ivan";
            secondPerson.Age = 18;
        }
    }
}
