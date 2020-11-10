using System;

namespace UniquePINcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberBoundary = int.Parse(Console.ReadLine());
            int secondNumberBoundary = int.Parse(Console.ReadLine());
            int thirdNumberBoundary = int.Parse(Console.ReadLine());

            for (int x1 = 2; x1 <= firstNumberBoundary; x1++)
            {
                if(x1 % 2 == 0)
                {
                    for (int x2 = 2; x2 <= secondNumberBoundary; x2++)
                    {
                        for (int x3 = 2; x3 <= thirdNumberBoundary; x3++)
                        {
                            if(x3 % 2 == 0)
                            {
                                if(x2 == 2 || x2 == 3 || x2 == 5 || x2 == 7)
                                {
                                    Console.WriteLine($"{x1} {x2} {x3} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
