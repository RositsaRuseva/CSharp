using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = 1;
            bool isBigger = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                   if (number > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(number + " ");
                    number++;
                }
                if(isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
