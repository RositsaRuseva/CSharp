using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models;
using WildFarm.Models.Contracts;

namespace WildFarm.Factories
{
    public static class AnimalFactory
    {
        public static Animal CreateAnimal(string[] animalData)
        {
            Animal animal = null;
            string animalType = animalData[0];
            string animalName = animalData[1];
            double animalWeight = double.Parse(animalData[2]);

            if (animalType == "Owl" || animalType == "Hen")
            {
                double wingSize = double.Parse(animalData[3]);
                if (animalType == "Owl")
                {
                    return animal = new Owl(animalName, animalWeight, wingSize);
                }
                return animal = new Hen(animalName, animalWeight, wingSize);
            }
            else if (animalType == "Dog" || animalType == "Mouse")
            {
                string livingRegion = animalData[3];
                if (animalType == "Dog")
                {
                    return animal = new Dog(animalName, animalWeight, livingRegion);
                }
                return animal = new Mouse(animalName, animalWeight, livingRegion);
            }
            else if (animalType == "Cat" || animalType == "Tiger")
            {
                string livingRegion = animalData[3];
                string breed = animalData[4];

                if (animalType == "Cat")
                {
                    return animal = new Cat(animalName, animalWeight, livingRegion, breed);
                }
                return animal = new Tiger(animalName, animalWeight, livingRegion, breed);
            }
            return animal;

        }
    }
}
