using System;
using System.Linq;
using System.Collections.Generic;

namespace MagicCards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(":").ToList();

            string input = Console.ReadLine();
            List<string> newList = new List<string>();

            while (input != "Ready")
            {
                string[] command = input.Split(" ").ToArray();
                string operation = command[0];
                if(operation == "Add")
                { 
                    string cardName = command[1];
                    if(list.Contains(cardName))
                    {
                        int index = list.IndexOf(cardName);
                        list.RemoveAt(index);
                        newList.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if(operation == "Insert")
                {
                    string cardName = command[1];
                    int index = int.Parse(command[2]);
                    if(list.Contains(cardName)&& index < newList.Count && index >= 0)
                    {
                        list.Remove(cardName);
                        newList.Insert(index, cardName);
                    }
                    else if(!list.Contains(cardName) && index !< newList.Count && index !>= 0)
                    {
                        Console.WriteLine("Error!");
                    }

                }
                else if(operation == "Remove")
                {
                    string cardName = command[1];
                    if(newList.Contains(cardName))
                    {
                        newList.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if(operation == "Swap")
                {
                    string card1 = command[1];
                    string card2 = command[2];
                    if(newList.Contains(card1) && newList.Contains(card2))
                    {
                        int index1 = newList.IndexOf(card1);
                        int index2 = newList.IndexOf(card2);
                        string temp1 = newList[index1];
                        string temp2 = newList[index2];

                        newList[index1] = temp2;
                        newList[index2] = temp1;
                    }
                }
                else if(operation == "Shuffle")
                {
                    newList.Reverse();
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
