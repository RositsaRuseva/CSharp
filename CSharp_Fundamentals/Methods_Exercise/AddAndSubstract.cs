using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Substract(n1, n2, n3));
        }

        static int Sum(int n1, int n2)
        {
            int resultSum = n1 + n2;
            return resultSum;
        }
        static int Substract(int n1, int n2, int n3)
        {
            int result = Sum(n1, n2) - n3;
            return result;
        }
    }
}
