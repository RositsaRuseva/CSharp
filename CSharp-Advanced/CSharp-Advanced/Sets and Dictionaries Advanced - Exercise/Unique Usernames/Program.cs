using System;
using System.Linq;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var uniqueNames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string names = Console.ReadLine();
                uniqueNames.Add(names);
            }
            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
