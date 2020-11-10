using System;
using System.Linq;
using System.Collections.Generic;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split(" ").ToArray();
                string operation = command[0];

                switch (operation)
                {
                    case "Shoot":
                        {
                            int index = int.Parse(command[1]);
                            int value = int.Parse(command[2]);
                            if(index < list.Count && index >= 0)
                            {
                                if(list[index] > value)
                                {
                                    list[index] -= value;
                                }
                                else
                                {
                                    list.RemoveAt(index);
                                }
                            }
                        }
                        break;
                    case "Add":
                        {
                            int index = int.Parse(command[1]);
                            int value = int.Parse(command[2]);

                            if(index < list.Count && index >= 0)
                            {
                                list.Insert(index, value);
                            }
                            else
                            {
                                Console.WriteLine("Invalid placement!");
                            }
                        }
                        break;
                    case "Strike":
                        {
                            int index = int.Parse(command[1]);
                            int radius = int.Parse(command[2]);
                            int start = index - radius;
                            int end = index + radius;

                            if(start >= 0 && end < list.Count)
                            {
                                list.RemoveRange(start, end - start + 1);
                            }
                            else
                            {
                                Console.WriteLine("Strike missed!");
                            }

                        }
                        break;
                        
                }
                input = Console.ReadLine();

                
            }
            Console.WriteLine(string.Join("|", list));
        }
    }
}
