using System;
using System.Linq;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToPass = int.Parse(Console.ReadLine());
            string input = string.Empty;
            Queue<string> cars = new Queue<string>();
            int pass = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                //cars.Enqueue(input);
                if(input == "green")
                {
                    for (int i = 0; i < numberToPass; i++)
                    {
                        if(cars.Count == 0)
                        {
                            continue;
                        }
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        pass++;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }
            Console.WriteLine($"{pass} cars passed the crossroads.");
        }
    }
}
