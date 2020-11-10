using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();
            for (int i = 0; i < input.Count/2;i++)
            {
                result.Add(input[i] + input[input.Count - i - 1]);
            }
            if(input.Count % 2 == 1)
            {
                result.Add(input[input.Count / 2]);
            }
            Console.WriteLine(String.Join(" ", result));

        }

       
        

    }
}
