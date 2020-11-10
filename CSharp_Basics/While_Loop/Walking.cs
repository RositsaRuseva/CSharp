using System;

namespace Walking1
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 10000;
            int sumSteps = 0;
            string steps = Console.ReadLine();

            while(true)
            {
                if(steps == "Going home")
                {
                    steps = Console.ReadLine();
                    sumSteps += int.Parse(steps);
                    break;
                }
                else
                {
                    sumSteps += int.Parse(steps);
                }
                if (sumSteps >= target)
                {
                    break;
                }
                steps = Console.ReadLine();

                
            }
            if (sumSteps >= target)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sumSteps - target} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{target - sumSteps} more steps to reach goal.");
            }
        }
    }
}
