using System;
using System.Linq;
using System.Collections.Generic;

namespace TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] command = input.Split(" ").ToArray();
                string operation = command[0];

                switch (operation)
                {
                    case "Delete":
                        {
                            int index = int.Parse(command[1]) + 1;
                            if (index < list.Count && index >= 0)
                            {
                                list.RemoveAt(index);
                            }
                        }
                        break;
                    case "Swap":
                        {
                            if (list.Contains(command[1]) && list.Contains(command[2]))
                            {
                                int firstIndex = list.IndexOf(command[1]);
                                int secondIndex = list.IndexOf(command[2]);
                                list.RemoveAt(firstIndex);
                                list.Insert(firstIndex, command[2]);
                                list.RemoveAt(secondIndex);
                                list.Insert(secondIndex, command[1]);

                                //string temp1 = list[firstIndex];
                                //string temp2 = list[secondIndex];

                                //list[firstIndex] = temp2;
                                //list[secondIndex] = temp1;
                                // for (int i = 0; i < list.Count; i++)
                                //{
                                //  if(list[i] == command[1])
                                //{
                                //  list[i] = command[2];
                                //}
                                //else if (list[i] == command[2])
                                //{
                                //  list[i] = command[1];
                                //}
                            }

                        }
                        break;

                    case "Put":
                        {
                            int index = int.Parse(command[2]) - 1;


                            if (index >= 0 && index <= list.Count)
                            {
                                list.Insert(index, command[1]);
                            }
                        }
                        break;
                    case "Sort":
                        {
                            list.Sort();
                            list.Reverse();

                        }
                        break;
                    case "Replace":
                        {
                            if (list.Contains(command[2]))
                            {
                                int index = list.IndexOf(command[2]);
                                list.Remove(command[2]);
                                list.Insert(index, command[1]);
                                
                            }
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));

        }
    }
}

