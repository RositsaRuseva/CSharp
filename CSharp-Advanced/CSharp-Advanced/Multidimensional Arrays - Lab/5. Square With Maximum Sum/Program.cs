using System;
using System.Linq;
using System.Collections.Generic;

namespace SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = ReadMatrix(size[0], size[1]);

            int maxSum = 0;
            int maxRow = -1;
            int maxCol = -1;
            MaxSquareSum(matrix, ref maxSum, ref maxRow, ref maxCol);

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }

        private static void MaxSquareSum(int[,] matrix, ref int maxSum, ref int maxRow, ref int maxCol)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var newSquareSum = matrix[row, col] +
                        matrix[row + 1, col] +
                        matrix[row, col + 1] +
                        matrix[row + 1, col + 1];
                    if (newSquareSum > maxSum)
                    {
                        maxSum = newSquareSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }

            }
            return matrix;
        }
    }
}
