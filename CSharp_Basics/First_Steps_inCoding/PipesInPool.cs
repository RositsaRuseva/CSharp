using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double firstPipe = H * P1;
            double secondPipe = H * P2;
            double filledPool = firstPipe + secondPipe;
            double filledPercent = 0.0;
            double P1Percent = 0.0;
            double P2Percent = 0.0;

            if (filledPool <= V)
            {   filledPercent = filledPool / V * 100;
                P1Percent = (P1 * H)/ filledPool * 100;
                P2Percent = (P2 * H)/ filledPool * 100;

                Console.WriteLine($"The pool is {filledPercent:F2}% full. Pipe 1: {P1Percent:F2}%. Pipe 2: {P2Percent:F2}%.");

            }

            else
            { Console.WriteLine($"For {H:F2} hours the pool overflows with {(filledPool - V):F2} liters.");
            }


        }
    }
}
