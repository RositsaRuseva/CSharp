using System;
using System.Linq;
using System.Collections.Generic;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];
            FillMatrix(matrix);

            string input = Console.ReadLine();
            while (input != "Bloom Bloom Plow")
            {
                int[] command = input.Split(" ").Select(int.Parse).ToArray();

                int affectedRow = command[0];
                int affectedCol = command[1];
                
                if (affectedRow >= 0 && affectedRow < matrix.GetLength(0)
                    && affectedCol >= 0 && affectedCol < matrix.GetLength(1))
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            if (row == affectedRow || col == affectedCol)
                            {
                                matrix[row, col]++;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                input = Console.ReadLine();
            }
            PrintMatrix(matrix);

        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = 0;
                }
            }
        }
    }
}
