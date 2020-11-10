using System;

namespace HalfSumelement1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;


            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                
                sum += number;

                if (number > max)
                {
                    max = number;
                }
                
            }

            int sumWithoutMaxNumber = sum - max;
            if (max == sumWithoutMaxNumber)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = " + max);
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMaxNumber);
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = " + diff);
            }
        }
    }
}
