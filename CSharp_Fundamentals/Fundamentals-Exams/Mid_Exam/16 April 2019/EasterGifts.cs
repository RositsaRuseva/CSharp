using System;
using System.Linq;
using System.Collections.Generic;

namespace EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine().Split(" ").ToList();

            string input = Console.ReadLine();

            while (input != "No Money")
            {
                string[] command = input.Split(" ");
                string operation = command[0];
                // string product = command[1];
                switch (operation)
                {
                    case "OutOfStock":
                        {
                            string product = command[1];
                            int index = gifts.IndexOf(product);
                            gifts[index] = "None";
                        }
                        break;
                    case "Required":
                        {
                            //string gift = command[1];
                            string product = command[2];
                            int index = int.Parse(product);
                            if (index >= 0 && index <= gifts.Count - 1)
                            {
                                gifts[index] = command[1];
                            }
                        }
                        break;
                    case "Just in case":
                        {
                            int index = (gifts.Count - 1);
                            gifts[index] = command[1];
                        }
                        break;
                }

            }
            var result = gifts.Where(x => x != "None");
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
