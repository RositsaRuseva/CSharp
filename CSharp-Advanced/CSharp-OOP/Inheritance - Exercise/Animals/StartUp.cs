using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           

            var command = Console.ReadLine();                      
            var animalsList = new List<Animal>();

            while (command != "Beast!")
            {
                var data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); 

                string name = data[0];
                int age = int.Parse(data[1]);

                Animal currentAnimal = null;

                if (command == "Dog")
                {
                    currentAnimal = new Dog(name, age, data[2]);
                }
                else if (command == "Cat")
                {
                    currentAnimal = new Cat(name, age, data[2]);
                }
                else if (command == "Frog")
                {
                    currentAnimal = new Frog(name, age, data[2]);
                }
                else if (command == "Kitten")
                {
                    currentAnimal = new Kitten(name, age);
                }
                else if (command == "Tomcat")
                {
                    currentAnimal = new Tomcat(name, age);
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }

                animalsList.Add(currentAnimal);


            }

            
            foreach (var item in animalsList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
