using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person person;
            var listOfPeople = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                person = new Person(input[0], int.Parse(input[1]));

                if (person.Age > 30)
                {
                    listOfPeople.Add(person);
                }
            }

            var sortedListOfPeople = listOfPeople.OrderBy(p => p.Name);

            foreach (var item in sortedListOfPeople)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }

        }
    }
}
