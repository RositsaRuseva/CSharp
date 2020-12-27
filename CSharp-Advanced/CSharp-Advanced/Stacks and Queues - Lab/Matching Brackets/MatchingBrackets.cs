using System;
using System.Linq;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    stack.Push(i);
                }
                else if(input[i] == ')')
                {
                    int finalIndex = i - stack.Pop();
                    result = input.Substring(i - finalIndex, finalIndex + 1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
