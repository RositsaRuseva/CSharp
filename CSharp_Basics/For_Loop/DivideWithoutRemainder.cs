using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }

            double resultp1 = (p1 / n) * 100;
            double resultp2 = (p2 / n) * 100;
            double resultp3 = (p3 / n) * 100;

            Console.WriteLine($"{resultp1:f2}%");
            Console.WriteLine($"{resultp2:f2}%");
            Console.WriteLine($"{resultp3:f2}%");


        }
    }
}
