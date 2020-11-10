using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ").ToArray();

            Console.WriteLine(string.Join(" ", array.Reverse()));
        }
    }
}
