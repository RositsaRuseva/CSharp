using System;
using System.Linq;
using System.Collections.Generic;

namespace CrossRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            int durationOfGreenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            string input = string.Empty;
            Queue<string> cars = new Queue<string>();
            int count = 0;

            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "green")
                {
                    int passed = durationOfGreenLight;
                    while (cars.Count > 0)
                    {
                        var car = cars.Peek();
                        int time = freeWindow + passed;

                        if (car.Length <= time)
                        {
                            passed -= car.Length;
                            cars.Dequeue();
                            count++;
                            if (passed<=0)
                            {
                                break;
                            }
                            
                        }
                        else
                        {
                            var crach = car.Substring(time,car.Length-time);
                            Console.WriteLine($"A crash happened!");
                            Console.WriteLine($"{car} was hit at {crach[0]}.");
                            return;

                        }
                     }
                }
                else { cars.Enqueue(input); }
            }
            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{count} total cars passed the crossroads.");
        }
    }
}
