using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = input.Length / 4;
            int[] newArray = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                newArray[i] = input[k - (i + 1)] + input[k + i];
                newArray[newArray.Length - 1 - i] = input[newArray.Length - 1 - i + k] + input[(newArray.Length - 1 - i) + (k + 2 * i + 1)];
            }
            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
