using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = ReadMatrix(n, n);
            string[] coordinates = Console.ReadLine().Split(" ");

            for (int i = 0; i < coordinates.Length; i++)
            {
                var bomb = coordinates[i]
                    .Split(",").Select(int.Parse).ToArray();
                if (matrix[bomb[0], bomb[1]] <= 0)
                {
                    continue;
                }
                for (int row =bomb[0] - 1; row <= bomb[0] + 1; row++)
                {
                    for (int col = bomb[1] -1; col <= bomb[1]+1; col++)
                    {
                        if (row == bomb[0] && col == bomb[1])
                        {
                            continue;
                        }
                        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col <matrix.GetLength(1))
                        {
                            if(matrix[row, col] > 0)
                            {
                                matrix[row, col] -= matrix[bomb[0], bomb[1]];
                            }
                        }
                    }
                }
                matrix[bomb[0], bomb[1]] = 0;
            }
            PrintResult(matrix);
            
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
        static void PrintResult(int[,] matrix)
        {
            StringBuilder result = new StringBuilder();
            int alive = 0;
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        alive++;
                        sum += matrix[row, col];
                    }
                }
            }
            result.AppendLine($"Alive cells: {alive}");
            result.AppendLine($"Sum: {sum}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    result.Append($"{matrix[row, col]} ");
                }
                result.AppendLine();
            }
            Console.WriteLine(result.ToString().Trim());
        }
    }

}
