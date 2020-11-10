using System;
using System.Collections.Generic;

namespace EncryptSortAndPrintArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> allStrings = new List<int>();

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                for (int j = 0; j < name.Length; j++)
                {
                    if(name[j] == 'a' || name[j] == 'e' || name[j] == 'i'
                        || name[j] == 'o' || name[j] == 'u' || name[j] == 'A'
                        || name[j] == 'E' || name[j] == 'I' || name[j] == 'O' || name[j] == 'U')
                    {
                        sum += ((char)name[j]) * name.Length;
                    }
                    else
                    {
                        sum += ((char)name[j]) / name.Length;
                    }
                }
                allStrings.Add(sum);
                sum = 0;

            }
            allStrings.Sort();

            foreach (var name in allStrings)
            {
                Console.WriteLine(name);
            }
        }
    }
}
