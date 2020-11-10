using System;
using System.Linq;
using System.Collections.Generic;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
