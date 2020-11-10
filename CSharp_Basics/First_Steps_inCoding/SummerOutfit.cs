using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();
            string outfit = string.Empty;
            string shoes = string.Empty;

            if (degrees >= 10 && degrees <= 18)
            {
                if (partOfTheDay == "Morning")
                { outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (partOfTheDay == "Afternoon" || partOfTheDay == "Evening") 
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (partOfTheDay == "Morning" || partOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partOfTheDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (degrees >= 25)
            {
                if (partOfTheDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partOfTheDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (partOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
