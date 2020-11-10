using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            decimal result = FirstFactorial(n1) / SecondFactorial(n2);
            Console.WriteLine($"{result:f2}");
        }

        
        static decimal FirstFactorial (int n1)
        {
            decimal factorial = 1;
            for (int i = 1; i <= n1; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static decimal SecondFactorial(int n2)
        {
            decimal factorial = 1;
            for (int i = 1; i <= n2; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

    }
}
