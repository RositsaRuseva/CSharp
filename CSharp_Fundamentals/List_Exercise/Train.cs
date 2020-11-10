using System;
using System.Linq;
using System.Collections.Generic;

namespace TrainLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] elements = command.Split();
                
                
                    if(elements[0] == "Add")
                    {
                       int passengers = int.Parse(elements[1]);
                       train.Add(passengers);
                    }
                else
                {
                    int number = int.Parse(elements[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if(train[i] + number <= maxCapacity)
                        {
                            train[i] += number;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
