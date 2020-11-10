using System;

namespace FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            string clubMember = Console.ReadLine();

            double price = 0.0;

            if (typeOfFuel == "Gas")
            {
                price = quantity * 0.93;
                if (clubMember == "Yes")
                {
                    price = quantity * (0.93 - 0.08);
                }
                if (quantity >= 20 && quantity <= 25)
                {
                    price *= 0.92;
                }
                else if (quantity > 25)
                {
                    price *= 0.90;
                }

            }
            else if (typeOfFuel == "Gasoline")
            {
                price = quantity * 2.22;
                if (clubMember == "Yes")
                {
                    price = quantity * (2.22 - 0.18);
                }
                if (quantity >= 20 && quantity <= 25)
                {
                    price *= 0.92;
                }
                else if (quantity > 25)
                {
                    price *= 0.90;
                }
            }
            else if (typeOfFuel == "Diesel")
            {
                price = quantity * 2.33;
                if (clubMember == "Yes")
                {
                    price = quantity * (2.33 - 0.12);
                }
                if (quantity >= 20 && quantity <= 25)
                {
                    price *= 0.92;
                }
                else if (quantity > 25)
                {
                    price *= 0.90;
                }
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
