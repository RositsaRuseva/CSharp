using System;
using System.Linq;
using System.Collections.Generic;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> price = new List<int>();
            price.AddRange(drumSet);

            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();

                if(command=="Hit it again, Gabsy!")
                {
                    break;
                }
                int hitPower = int.Parse(command);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;
                    if(drumSet[i] <= 0)
                    {
                        if(savings - (price[i] * 3) >= 0)
                        {
                            savings = savings - (price[i] * 3);
                            drumSet[i] = price[i];
                        }
                    }
                }
                for (int i = 0; i < drumSet.Count; i++)
                {
                    if(drumSet[i] <= 0)
                    {
                        drumSet.Remove(drumSet[i]);
                        price.Remove(price[i]);
                    }
                }
            }
            foreach (var drum in drumSet)
            {
                Console.Write(drum + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
           
        }
    }
}
