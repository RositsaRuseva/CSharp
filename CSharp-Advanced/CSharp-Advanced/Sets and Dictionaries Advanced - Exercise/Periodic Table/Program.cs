using System;
using System.Linq;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                for (int k = 0; k < input.Length; k++)
                {
                    set.Add(input[k]);
                }

            }
            foreach (var item in set)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
