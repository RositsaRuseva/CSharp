using System;
using System.Linq;
using System.Collections.Generic;

namespace EasterShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine().Split(" ").ToList();
            int n = int.Parse(Console.ReadLine());
            //string command = "";
            while (n > 0)
            {
                string[] command = Console.ReadLine().Split(" ");
                n--;
                
                if(command[0] == "Include")
                {
                    shops.Add(command[1]);
                }
                else if(command[0] == "Visit")
                {
                    if (command[1] == "first")
                    {
                        int range = int.Parse(command[2]);
                        if (shops.Count >= range)
                        {
                            int index = shops.IndexOf(shops[0]);
                            shops.RemoveRange(index, range);
                        }
                        
                    }
                    else if (command[1] == "last")
                    {
                        int range = int.Parse(command[2]);
                        if (shops.Count >= range)
                        {
                            // int index = shops.IndexOf(shops[shops.Count - 1]);
                            // shops.RemoveRange(index, range);
                            shops.Reverse();
                            int index = shops.IndexOf(shops[0]);
                            shops.RemoveRange(index, range);
                            shops.Reverse();
                        }
                        
                    }
                    
                }
                else if(command[0] == "Prefer")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);

                    if (shops.Count > index1 && shops.Count > index2)
                    {
                        string temp1 = shops[index1];
                        string temp2 = shops[index2];

                        shops[index1] = temp2;
                        shops[index2] = temp1;
                    }
                }
                else if(command[0] == "Place")
                {
                    int index = int.Parse(command[2]);
                    if(shops.Count > index + 1)
                    {
                        int insertIndex = index + 1;
                        shops.Insert(insertIndex, command[1]);
                    }
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(String.Join(" ", shops));
        }
    }
}
