using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> n = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < n.Count; i++)
            {
                int nextIndex = 0;

                if (i + 1 > n.Count - 1)
                {
                    break;
                }
                else
                {
                    nextIndex = i + 1;
                }
                if (n[i] == n[nextIndex])
                {
                    n[i] += n[nextIndex];
                    n.RemoveAt(nextIndex);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", n));
        }
    }
}
