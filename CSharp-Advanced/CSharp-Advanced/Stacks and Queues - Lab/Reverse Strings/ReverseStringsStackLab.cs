using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseStringsStackLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // string reversed = new Stack<>(input);

            Stack<char> reversed = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                reversed.Push(input[i]);
            }
            while (reversed.Count > 0)
            {
                Console.Write(reversed.Pop());
            }
            
        }
    }
}
