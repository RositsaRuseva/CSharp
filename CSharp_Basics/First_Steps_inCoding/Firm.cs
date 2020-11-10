using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double projectHours = double.Parse(Console.ReadLine());
            double availableDays = double.Parse(Console.ReadLine());
            double overtimeWorkers = double.Parse(Console.ReadLine());
            double workDays = 0.9 * availableDays;
            double overtime = overtimeWorkers * 2 * availableDays;
            double workHours = Math.Floor(workDays * 8 + overtime);


            if (projectHours <= workHours)
            {
                Console.WriteLine("Yes!{0} hours left.", workHours - projectHours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", projectHours - workHours);
            }
        }
    }
}
