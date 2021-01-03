using System;
using System.Linq;
using System.Collections.Generic;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = ReadMatrix(size[0], size[1]);

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int rol = 0; rol < matrix.GetLength(0); rol++)
                {
                    sum += matrix[rol, col];
                }
                Console.WriteLine(sum);
            }
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
