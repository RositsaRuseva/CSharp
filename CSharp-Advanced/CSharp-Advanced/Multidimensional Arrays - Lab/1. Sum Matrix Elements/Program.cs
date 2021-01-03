using System;
using System.Linq;
using System.Collections.Generic;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
              var rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
              matrix[row, col] = rowData[col];
            }
            }
            //Console.WriteLine(PrintMatrix(matrix));
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(SumMatrix(matrix));
            
       
        }
        static int SumMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
                
            }
            return sum;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
