using System;
using System.Linq;
using System.Collections.Generic;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] matrix = new double[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                double[] rowData = Console.ReadLine().Split(" ").
                    Select(double.Parse).ToArray();
                matrix[row] = new double[rowData.Length];
                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                double[] row1 = matrix[row];
                double[] row2 = matrix[row + 1];

                if(row1.Length == row2.Length)
                {
                    matrix[row] = row1.Select(e => e * 2).ToArray();
                    matrix[row + 1] = row2.Select(e => e * 2).ToArray();
                }
                else
                {
                    matrix[row] = row1.Select(e => e / 2).ToArray();
                    matrix[row + 1] = row2.Select(e => e / 2).ToArray();
                }
            }
            string commandInput = Console.ReadLine();
            while (commandInput != "End")
            {
                string[] tokens = commandInput.Split();
                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (ValidateCell(matrix, row, col))
                {
                    if (command == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else
                    {
                        matrix[row][col] -= value;
                    }
                }

                commandInput = Console.ReadLine();
            }
            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }

        private static bool ValidateCell(double[][] matrix, int row, int col)
        {
            bool isValid = false;

            if (row >= 0 && row < matrix.Length
                && col >= 0 && col < matrix[row].Length)
            {
                isValid = true;
            }
            return isValid;
        }

        
    }

}
