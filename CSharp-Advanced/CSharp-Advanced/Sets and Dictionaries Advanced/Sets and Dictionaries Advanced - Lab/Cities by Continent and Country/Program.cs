using System;
using System.Linq;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                
                if (!dict.ContainsKey(continent))
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                }
                if(!dict[continent].ContainsKey(country))
                {
                    dict[continent].Add(country, new List<string>());
                }
                dict[continent][country].Add(city);
                
            }
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key}:");
                foreach (var item in pair.Value)
                {
                    Console.WriteLine($" {item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
