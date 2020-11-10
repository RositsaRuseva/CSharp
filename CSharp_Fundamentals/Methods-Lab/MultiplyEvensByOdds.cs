using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            input = Math.Abs(input);

            Console.WriteLine(Multiply(input));
        }

        static int Multiply(int input)
        {
            int result = CalculateEvenDigitsSum(input) * CalculateOddDigitsSum(input);
            return result;
        }

        static int CalculateOddDigitsSum(int input)
        {
            string number = input.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = int.Parse((number[i]).ToString());
                if (currentDigit %2 == 1)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
        static int CalculateEvenDigitsSum(int input)
        {
            string number = input.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = int.Parse((number[i]).ToString());
                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
    }
}
