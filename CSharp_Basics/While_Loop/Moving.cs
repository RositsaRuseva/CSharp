using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int wideFreeSpace = int.Parse(Console.ReadLine());
            int lenghtFreeSpace = int.Parse(Console.ReadLine());
            int heightFreeSpace = int.Parse(Console.ReadLine());

            int sum = 0;
            int totalFreeSpace = wideFreeSpace * lenghtFreeSpace * heightFreeSpace;

            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                
                sum += n;
                string input = Console.ReadLine();
                if (input == "Done" && sum>= totalFreeSpace)
                {
                    Console.WriteLine($"{sum - totalFreeSpace} Cubic meters left.");
                    break;
                }
                if (sum< totalFreeSpace)
                {
                    Console.WriteLine($"No more free space! You need {totalFreeSpace - sum} Cubic meters more.");
                }

            }
        }
    }
}
