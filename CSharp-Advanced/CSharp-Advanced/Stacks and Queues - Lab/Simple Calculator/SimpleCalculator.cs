using System;
using System.Linq;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                //PrintStack(stack);
                int first = int.Parse(stack.Pop());
                string operators = stack.Pop();
                int second = int.Parse(stack.Pop());

                switch (operators)
                {
                    case "+": stack.Push((first + second).ToString());
                        break;
                    case "-": stack.Push((first - second).ToString());
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine(stack.Pop());
            

        }
        static void PrintStack(Stack<string> stack)
        {
            foreach (var item in stack)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
