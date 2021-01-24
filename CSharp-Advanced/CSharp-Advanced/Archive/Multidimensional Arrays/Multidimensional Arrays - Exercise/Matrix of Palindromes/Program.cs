using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrixOfPolindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input_arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int row = input_arr[0];
            int col = input_arr[1];
            string[,] matrix = new string[row, col];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    string firstAndLastLetter = alphabet[rows].ToString();
                    string middleLetter = alphabet[rows + cols].ToString();

                    string matrixElement = firstAndLastLetter + middleLetter + firstAndLastLetter;
                    matrix[rows, cols] = matrixElement;
                }
            }
            PrintMatrix(matrix);

        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
