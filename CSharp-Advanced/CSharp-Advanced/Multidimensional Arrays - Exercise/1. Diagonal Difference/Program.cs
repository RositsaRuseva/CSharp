using System;
using System.Linq;
using System.Collections.Generic;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(n, n);
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                leftSum += matrix[i, i];
                
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == n - j - 1)
                    {
                        rightSum += matrix[i, j];
                    }
                }
            }
            // Console.WriteLine(leftSum);using System;
using System.Linq;
using System.Collections.Generic;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(n, n);
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                leftSum += matrix[i, i];
                
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == n - j - 1)
                    {
                        rightSum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"{Math.Abs(leftSum - rightSum)}");
        
        }
        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }

            }
            return matrix;
        }
    }
}

            // Console.WriteLine(rightSum);
            Console.WriteLine($"{Math.Abs(leftSum - rightSum)}");
        
        }
        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }

            }
            return matrix;
        }
    }
}
