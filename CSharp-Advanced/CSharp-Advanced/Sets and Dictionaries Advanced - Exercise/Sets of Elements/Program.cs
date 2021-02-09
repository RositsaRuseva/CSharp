using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            var first = new HashSet<int>();
            var second = new HashSet<int>();

            for (int i = 1; i <= input.Sum(); i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i <= n)
                {
                    first.Add(number);
                }
                else
                {
                    second.Add(number);
                }
            }
            foreach (var item in first)
            {
                if(second.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
