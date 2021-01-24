using System;
using System.Linq;
using System.Collections.Generic;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            var match = new Dictionary<double, int>();

            
            for (int i = 0; i < input.Count; i++)
            {
                double currentNumber = input[i];
                if(!match.ContainsKey(currentNumber))
                {
                    match.Add(currentNumber, 1);
                }
                else
                {
                    
                    match[currentNumber] += 1;
                }
            }
            foreach (var item in match)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
