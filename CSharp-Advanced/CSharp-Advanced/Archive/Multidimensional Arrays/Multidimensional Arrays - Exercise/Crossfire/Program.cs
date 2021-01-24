using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossfire
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];
            FillMatrix(rows, cols, matrix);

            

            string input = Console.ReadLine();
            while (input != "Nuke it from orbit")
            {
                int[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                int row = tokens[0];
                int col = tokens[1];
                int radius = tokens[2];

                if (Validate(matrix, row, col))
                {
                    matrix[row, col] = 0;
                }
                //left side
                int currentCol = col - 1;
                for (int i = 0; i < radius; i++)
                {
                    if (Validate(matrix, row, currentCol))
                    {
                        matrix[row, currentCol] = 0;
                    }
                    currentCol--;
                }

                //right side
                currentCol = col + 1;
                for (int i = 0; i < radius; i++)
                {
                    if (Validate(matrix, row, currentCol))
                    {
                        matrix[row, currentCol] = 0;
                    }
                    currentCol++;
                }
                //up
                int currentRow = row - 1;
                for (int i = 0; i < radius; i++)
                {
                    if (Validate(matrix, currentRow, col))
                    {
                        matrix[currentRow, col] = 0;
                    }
                    currentRow--;
                }
                //down
                currentRow = row + 1;
                for (int i = 0; i < radius; i++)
                {
                    if (Validate(matrix, currentRow, col))
                    {
                        matrix[currentRow, col] = 0;
                    }
                    currentRow++;
                }
                //Remove marked cells
                matrix = RemoveEmptyCells(matrix);

                GC.Collect();
                input = Console.ReadLine();

            }
            Print(matrix);
        }
        private static int[,] RemoveEmptyCells(int[,] matrix)
        {
            //push empty cols to the end
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Queue<int> currentRow = new Queue<int>();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        currentRow.Enqueue(matrix[i, j]);
                    }
                }
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (currentRow.Count > 0)
                    {
                        matrix[i, j] = currentRow.Dequeue();
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            //check for empty rows and remove them
            List<int> emptyRows = new List<int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] != 0)
                    {
                        break;
                    }
                    if (j == matrix.GetLength(1) -1 && matrix[i,j] ==0)
                    {
                        emptyRows.Add(i);
                    }
                }
            }
            if (emptyRows.Count == 0)
            {
                return matrix;
            }
            else
            {
                int reduceRows = matrix.GetLength(0) - emptyRows.Count;
                int reduceCols = matrix.GetLength(1);
                int[,] reducedMatrix = new int[reduceRows, reduceCols];

                int reducedMatrixRow = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (emptyRows.Contains(i))
                    {
                        continue;
                    }
                    int reducedMatrixCol = 0;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        reducedMatrix[reducedMatrixRow, reducedMatrixCol] = matrix[i, j];
                        reducedMatrixCol++;
                    }
                    reducedMatrixRow++;
                }
                return reducedMatrix;
            }
        }
        private static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        private static bool Validate(int[,] matrix, int row, int col)
        {
            if (row < 0 || col < 0)
            {
                return false;
            }
            if (row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return false;
            }
            return true;
        }

        private static void FillMatrix(int rows, int cols, int[,] matrix)
        {
            int cellValue = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = cellValue;
                    cellValue++;
                }
            }
        }

        private static void PrintMatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
