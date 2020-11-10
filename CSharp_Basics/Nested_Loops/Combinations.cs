using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int x1 = 0; x1 <= 25; x1++)
            {
                for (int x2 = 0; x2 <= 25; x2++)
                {
                    for (int x3 = 0; x3 <= 25; x3++)
                    {
                        int combination = x1 + x2 + x3;
                        
                        if(combination == n)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }

    }
}
