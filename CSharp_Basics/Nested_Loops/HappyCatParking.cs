using System;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int hoursCountPerDay = int.Parse(Console.ReadLine());

            double currentSumPrice = 0;
            double totalSumPrice = 0;

            for (int day = 1; day <= daysCount; day++)
            {
                for (int hours = 1; hours <= hoursCountPerDay; hours++)
                {
                    if (day % 2 == 0 && hours % 2 != 0)
                    {
                        currentSumPrice += 2.50;
                        totalSumPrice += 2.50;
                    }
                    else if ( day % 2 != 0 && hours % 2 == 0)
                    {
                        currentSumPrice += 1.25;
                        totalSumPrice += 1.25;
                    }
                    else
                    {
                        currentSumPrice += 1;
                        totalSumPrice += 1;
                    }

                }
                Console.WriteLine($"Day: {day} - {currentSumPrice:f2} leva");
                currentSumPrice = 0;
            }
            Console.WriteLine($"Total: {totalSumPrice:F2} leva");
        }
    }
}
