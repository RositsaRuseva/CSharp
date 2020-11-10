using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowBoundary = int.Parse(Console.ReadLine());
            int upBoundary = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int x1 = lowBoundary; x1 <= upBoundary; x1++)
            {
                for (int x2 = lowBoundary; x2 <= upBoundary; x2++)
                {
                    sum = x1 + x2;
                    counter++;

                    if(sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({x1} + {x2} = {magicNumber})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
