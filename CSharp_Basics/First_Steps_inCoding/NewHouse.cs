using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (flowerType == "Roses")
            { price = 5 * flowerNumber;
                if (flowerNumber > 80)
                {
                    price *= 0.90;
                }
            }
            else if (flowerType == "Dahlias")
            {
                price = 3.80 * flowerNumber;
                if (flowerNumber > 90)
                {
                    price *= 0.85;
                }
            }
            else if (flowerType == "Tulips")
            {
                price = 2.80 * flowerNumber;
                if (flowerNumber > 80)
                {
                    price *= 0.85;
                }
            }
            else if (flowerType == "Narcissus")
            {
                price = 3.00 * flowerNumber;
                if (flowerNumber < 120)
                {
                    price *= 1.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                price = 2.50 * flowerNumber;
                if (flowerNumber < 80)
                {
                    price *= 1.20;
                }
            }
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerNumber} {flowerType} and {(budget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget - price):f2} leva more.");
            }
            
        }
    }
}
