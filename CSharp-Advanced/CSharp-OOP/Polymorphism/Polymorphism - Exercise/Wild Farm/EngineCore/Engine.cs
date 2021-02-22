using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.EngineCore.Contracts;
using WildFarm.Factories;
using WildFarm.Models.Contracts;

namespace WildFarm.EngineCore
{
    public class Engine : IEngine
    {
        public void Run()
        {
            string input = string.Empty;
            List<Animal> listOfAnimals = new List<Animal>();
            while ((input = Console.ReadLine()) != "E")
            {
                string[] animalData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string[] foodData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Animal animal = AnimalFactory.CreateAnimal(animalData);
                listOfAnimals.Add(animal);
                Food food = FoodFactory.CreateFood(foodData);
                Console.WriteLine(animal.ProduceSound());
                try
                {
                    animal.Eat(food);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
            listOfAnimals.ForEach(Console.WriteLine);
        }
    }
}
