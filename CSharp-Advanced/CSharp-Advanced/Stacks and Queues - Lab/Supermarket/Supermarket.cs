using System;
using System.Linq;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Queue<string> names = new Queue<string>();

            while ((input = Console.ReadLine()) != "End")
            {
                //names.Enqueue(input);
                if(input == "Paid")
                {
                    while (names.Count>0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                    continue;
                    
                }
                names.Enqueue(input);

                //input = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
