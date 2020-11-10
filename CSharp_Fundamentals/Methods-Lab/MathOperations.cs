using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double n2 = double.Parse(Console.ReadLine());

            double result = Calculate(n1, operation, n2);
            Console.WriteLine($"{result}");

        }

        private static double Calculate(double n1, string operation, double n2)
        {
            double result = 0;
            switch (operation)
            {
                case "/":
                    result = n1 / n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
            }
            return result;

        }
    }
}
