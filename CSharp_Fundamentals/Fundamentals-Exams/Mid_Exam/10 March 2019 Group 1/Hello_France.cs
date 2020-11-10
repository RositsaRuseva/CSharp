using System;
using System.Linq;
using System.Collections.Generic;

namespace Hello_France
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> clothes = Console.ReadLine().Split("|").ToList();
            double budget = double.Parse(Console.ReadLine());

            double profit = 0;
            List<double> prices = new List<double>();

            for (int i = 0; i < clothes.Count; i++)
            {
                string itemType = clothes[i].Split("->")[0];
                double price = double.Parse(clothes[i].Split("->").Last());

                if (itemType == "Clothes" && price <= 50.00 && budget - price >= 0) // 3 checks = 1: Type, 2: Price, 3: Available Money
                {
                    budget -= price;
                    profit += price * 0.40;
                    prices.Add(price * 1.40);
                }
                else if (itemType == "Shoes" && price <= 35.00 && budget - price >= 0) // 3 checks = 1: Type, 2: Price, 3: Available Money
                {
                    budget -= price;
                    profit += price * 0.40;
                    prices.Add(price * 1.40);
                }
                else if (itemType == "Accessories" && price <= 20.50 && budget - price >= 0) // 3 checks = 1: Type, 2: Price, 3: Available Money
                {
                    budget -= price;
                    profit += price * 0.40;
                    prices.Add(price * 1.40);
                }
            }
            foreach (var item in prices)
            {

                Console.Write($"{item:F2} ");

            }

            Console.WriteLine();

            Console.WriteLine($"Profit: {profit:F2}");

            if (budget + prices.Sum() >= 150.00)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
        }
    }
