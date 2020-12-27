using System;
using System.Linq;
using System.Collections.Generic;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>(input);
            List<int> evenNumber = new List<int>();
            while (numbers.Count > 0)
            {
                int number = numbers.Dequeue();
                if (number % 2 == 0)
                {
                    evenNumber.Add(number);
                }
            }
            Console.WriteLine(string.Join(", ", evenNumber));
        }
    }
}
