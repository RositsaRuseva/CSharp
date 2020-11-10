using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeEfficiency1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());

            int peopleCount = int.Parse(Console.ReadLine());

            int totalEfficiency = employeeEfficiency1 + employee2 + employee3;
            int hours = 0;
            while (peopleCount > 0)
            {
                hours++;
                if(hours % 4 == 0)
                {
                    continue;
                }
                peopleCount -= totalEfficiency;
            }
            Console.WriteLine($"Time needed: {hours}h.");


        }
    }
}
