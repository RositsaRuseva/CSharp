using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number < 400)
                {
                    p2++;
                }
                else if (number >= 400 && number < 600)
                {
                    p3++;
                }
                else if (number >= 600 && number < 800)
                {
                    p4++;
                }
                else if (number >= 800)
                {
                    p5++;
                }
                
            }

            double result1 = (p1 / n) * 100;
            double result2 = (p2 / n) * 100;
            double result3 = (p3 / n) * 100;
            double result4 = (p4 / n) * 100;
            double result5 = (p5 / n) * 100;

            Console.WriteLine($"{result1:f2}%");
            Console.WriteLine($"{result2:f2}%");
            Console.WriteLine($"{result3:f2}%");
            Console.WriteLine($"{result4:f2}%");
            Console.WriteLine($"{result5:f2}%");



        }
    }
}
