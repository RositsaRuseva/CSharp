using System;

namespace TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayFor1Person = double.Parse(Console.ReadLine());
            double foodPerFayFor1Person = double.Parse(Console.ReadLine());

            double totalWater = days * players * waterPerDayFor1Person;
            double totalFood = days * players * foodPerFayFor1Person;

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;
                if(groupEnergy <= 0)
                {
                    break;
                }
                if (i % 2 == 0)
                {
                    groupEnergy *= 1.05;
                    totalWater *= 0.70;
                }
                if (i % 3 ==0)
                {
                    totalFood -= totalFood / players;
                    groupEnergy *= 1.10;
                }
            }
           
            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }
        }
    }
}
