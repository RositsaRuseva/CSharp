using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty());
            stack.Push("Dimitar");
            stack.Push("Stefan");
            stack.Push("Peter");
            Console.WriteLine(stack.IsEmpty());

            Console.WriteLine(string.Join(" ", stack.AddRange()));
        }
    }
}
