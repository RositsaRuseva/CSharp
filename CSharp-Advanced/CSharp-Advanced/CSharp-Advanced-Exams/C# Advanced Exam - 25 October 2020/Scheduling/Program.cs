using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine()
                .Split(", ").Select(int.Parse).ToArray();
            int[] secondInput = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            int task = int.Parse(Console.ReadLine());

            var taskCollection = new Stack<int>(firstInput);
            var threadCollection = new Queue<int>(secondInput);
            while (taskCollection.Count > 0 && threadCollection.Count > 0)
            {
                if (taskCollection.Peek() == task)
                {
                    Console.WriteLine($"Thread with value {threadCollection.Peek()} killed task {taskCollection.Peek()}");
                    break;
                }

                if (threadCollection.Peek() >= taskCollection.Peek())
                {
                    threadCollection.Dequeue();
                    taskCollection.Pop();
                }
                else if (threadCollection.Peek() < taskCollection.Peek())
                {
                    threadCollection.Dequeue();
                }
            }
            Console.WriteLine(String.Join(" ",threadCollection));
        }
    }
}
