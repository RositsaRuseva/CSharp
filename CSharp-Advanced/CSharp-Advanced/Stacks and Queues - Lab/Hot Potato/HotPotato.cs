using System;
using System.Linq;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Queue<string> kids = new Queue<string>(input);
            int n = int.Parse(Console.ReadLine());

            int counter = n;
            while (kids.Count > 1)
            {
                counter--;
                if(counter == 0)
                {
                    Console.WriteLine($"Removed {kids.Dequeue()}");
                    counter = n;
                    continue;
                }
                kids.Enqueue(kids.Dequeue());
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
            {

            }
        }
    }
}
