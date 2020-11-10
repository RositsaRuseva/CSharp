using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] bombData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int specialNumber = bombData[0];
            int power = bombData[1];

            int bombIndex = input.IndexOf(specialNumber);
            while (bombIndex != -1)
            {
                int leftNumbers = bombIndex - power;
                int rightNumbers = bombIndex + power;

                if(leftNumbers < 0)
                {
                    leftNumbers = 0;
                }
                if(rightNumbers > input.Count - 1)
                {
                    rightNumbers = input.Count - 1;
                }
                input.RemoveRange(leftNumbers, rightNumbers - leftNumbers + 1);
                bombIndex = input.IndexOf(specialNumber);
            }

            int sum = 0;
            foreach (var item in input)
            {
                sum += item;
            }
            Console.WriteLine(sum);
            // Console.WriteLine(String.Join(" ", input));
        }
    }
}
