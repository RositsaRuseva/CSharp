using System;
using System.Linq;
using System.Collections.Generic;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var stack = new Stack<int>(input);

            while (true)
            {
                string[] command = Console.ReadLine().ToLower().Split(" ").ToArray();
                if(command[0] == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));

                }
                else if(command[0] == "remove")
                {
                    var count = int.Parse(command[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            if(stack.Any())
                            {
                                stack.Pop();
                            }
                        }
                    }
              
                }
                else if(command[0] == "end")
                {
                    break;
                }
            }
            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
