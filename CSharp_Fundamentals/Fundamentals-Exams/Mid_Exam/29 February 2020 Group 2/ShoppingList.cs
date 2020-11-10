using System;
using System.Linq;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("!").ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] command = input.Split(" ").ToArray();
                string operation = command[0];

                switch (operation)
                {
                    case "Urgent":
                        {
                            string item = command[1];
                            if(!list.Contains(item))
                            {
                                list.Insert(0, item);
                            }
                        }
                        break;
                    case "Unnecessary":
                        {
                            string item = command[1];
                            if(list.Contains(item))
                            {
                                list.Remove(item);
                            }
                        }
                        break;
                    case "Correct":
                        {
                            string oldItem = command[1];
                            string newItem = command[2];

                            if(list.Contains(oldItem))
                            {
                                int index = list.IndexOf(oldItem);
                                list[index] = newItem;
                            }
                        }
                        break;
                    case "Rearrange":
                        {
                            string item = command[1];
                            if(list.Contains(item))
                            {
                                list.Remove(item);
                                list.Insert(list.Count, item);
                            }
                        }
                        break;
                    
                }

                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
