using System;
using System.Runtime.CompilerServices;

namespace ToysShopFinalRR
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double discountedPrice = 0;
            double total = 0;
            double discount = 0;
            double rent = 0;

            double totalPrice = puzzles * 2.60 + dolls * 3 + teddyBears * 4.10 + minions * 8.20 + trucks * 2;
            int toys = puzzles + dolls + teddyBears + minions + trucks;

            if (toys >= 50)
            {   discount = totalPrice * 0.25;
                discountedPrice = totalPrice - discount;
                rent = discountedPrice * 0.10;
                total = discountedPrice - rent;

            }
            else
            {   discountedPrice = totalPrice;
                rent = discountedPrice * 0.10;
                total = discountedPrice - rent;
            }

            if (total >= tripPrice)
            { Console.WriteLine($"Yes! {(total - tripPrice):f2} lv left.");
            }
            else
            { Console.WriteLine($"Not enough money! {(tripPrice - total):f2} lv needed.");
            }
        }
    }
}
