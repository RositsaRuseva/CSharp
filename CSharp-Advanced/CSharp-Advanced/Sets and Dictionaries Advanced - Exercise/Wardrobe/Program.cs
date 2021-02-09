using System;
using System.Linq;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(",");

                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                }
                for (int k = 0; k < clothes.Length; k++)
                {
                    if (!dict[color].ContainsKey(clothes[k]))
                    {
                        dict[color].Add(clothes[k], 0);
                    }
                    dict[color][clothes[k]]++;
                }
            }
            var command = Console.ReadLine().Split(" ");

            foreach (var color in dict)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var clothes in color.Value)
                {
                    if(clothes.Key == command[1] && color.Key == command[0])
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                }
            }

        }
    }
}
