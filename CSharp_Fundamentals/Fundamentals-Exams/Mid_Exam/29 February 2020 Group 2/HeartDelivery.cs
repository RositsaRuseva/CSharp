using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console
                                 .ReadLine()
                                 .Split("@")
                                 .Select(int.Parse)
                                 .ToList();

            string command = Console.ReadLine();
            int curentIndex = 0;
            int jumpLenght = 0;
            while (command != "Love!")
            {
                List<string> splitted = command
                                     .Split(" ")
                                     .ToList();
                jumpLenght = int.Parse(splitted[1]);
                if (splitted[0] == "Jump")
                {
                    curentIndex += jumpLenght;
                    if (curentIndex >= input.Count)
                    {
                        curentIndex = 0;
                    }
                    if (input[curentIndex] != 0)
                    {
                        input[curentIndex] -= 2;
                        if (input[curentIndex] == 0)
                        {
                            Console.WriteLine($"Place {curentIndex} has Valentine's day.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Place {curentIndex} already had Valentine's day.");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {curentIndex}.");


            int count = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] != 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {count} places.");
            }
        }
    }
}