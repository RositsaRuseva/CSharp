using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangle(input);

        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void PrintTriangle(int input)
        {
            for (int j = 1; j <= input; j++)
            {
                PrintLine(1, j);
            }
            for (int j = input-1; j >= 1; j--)
            {
                PrintLine(1, j);
            }
            

            }
        }
    }

