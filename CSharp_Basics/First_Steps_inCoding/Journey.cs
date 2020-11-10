using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = string.Empty;
            double spendedMoney = 0.0;
            string placeToStay = string.Empty;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    spendedMoney = budget * 0.30;
                    placeToStay = "Camp";
                }
                else if (season == "winter")
                {
                    spendedMoney = budget * 0.70;
                    placeToStay = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spendedMoney = budget * 0.40;
                    placeToStay = "Camp";
                }
                else if (season == "winter")
                {
                    spendedMoney = budget * 0.80;
                    placeToStay = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                spendedMoney = budget * 0.90;
                placeToStay = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToStay} - {spendedMoney:f2}");
        }
    }
}
