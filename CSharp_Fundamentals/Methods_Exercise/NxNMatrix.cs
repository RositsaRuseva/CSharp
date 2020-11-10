using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);
        }

        static void Matrix(int n)
        {
            for (int rows = 0; rows < n; rows++)
            {
                for (int collumns = 0; collumns < n; collumns++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
