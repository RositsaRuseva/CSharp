using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {  //Дадени са 2 * n - на брой числа. Първото и второто формират двойка, третото и четвъртото също и т.н.
            //    Всяка двойка има стойност – сумата от съставящите я числа.Напишете програма, която проверява дали всички
            //    двойки имат еднаква стойност или печата максималната разлика между две последователни двойки.
            //    Ако всички двойки имат еднаква стойност, отпечатайте "Yes, value={Value}" + стойността.
            //    В противен случай отпечатайте "No, maxdiff={Difference}" + максималната разлика.
            int n = int.Parse(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum1 = number1 + number2;
            int sum2 = sum1;
            bool checkTrue = true;
            int maxValue = 0;
            int difference = 0;
            for (int i = 1; i <= n - 1; i++)
            {
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
                sum1 = number2 + number1;
                if (sum1 != sum2)
                {
                    checkTrue = false;
                }
                difference = Math.Abs(sum1 - sum2);
                if (difference > maxValue)
                {
                    maxValue = difference;
                }
                sum2 = sum1;
            }
            if (checkTrue)
            {
                Console.WriteLine($"Yes, value={sum1}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxValue}");
            }
        }
    }
}
