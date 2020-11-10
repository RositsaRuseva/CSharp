using System;
using System.Linq;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                List<string> input = Console.ReadLine().Split(", ").ToList();

                string command = input[0];

                if(command == "Add")
                {
                    string cardName = input[1];
                    if(list.Contains(cardName))
                    {
                        Console.WriteLine("Card is already bought");
                    }
                    else
                    {
                        Console.WriteLine("Card successfully bought");
                        list.Add(cardName);
                    }
                }
                else if(command == "Remove")
                {
                    string cardName = input[1];
                    if(list.Contains(cardName))
                    {
                        Console.WriteLine("Card successfully sold");
                        list.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if(command == "Remove At")
                {
                    int index = int.Parse(input[1]);
                    if(index < list.Count && index >= 0)
                    {
                        list.RemoveAt(index);
                        Console.WriteLine("Card successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if(command == "Insert")
                {
                    int index = int.Parse(input[1]);
                    string cardName = input[2];
                    if(index < list.Count && index >= 0)
                    {
                        if(list.Contains(cardName))
                        {
                            Console.WriteLine("Card is already bought");
                        }
                        else
                        {
                            list.Insert(index, cardName);
                            Console.WriteLine("Card successfully bought");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                //Console.WriteLine(command);

            }
            Console.WriteLine(string.Join(", ",list));
        }
    }
}
