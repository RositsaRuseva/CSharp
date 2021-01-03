using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string[,] matrix = ReadMatrix(size[0], size[1]);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(" ");
                if(command[0] == "swap" && command.Length == 5)
                {
                    int row = int.Parse(command[1]);
                    int column = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int column2 = int.Parse(command[4]);
                    if(row >= 0 && row < size[0]
                        && column >= 0 && column < size[1]
                        && row2 >= 0 && row2 < size[0]
                        && column2 >= 0 && column2 < size[1])
                    {
                        string temp = matrix[row, column];
                        matrix[row, column] = matrix[row2, column2];
                        matrix[row2, column2] = temp;
                        PrintMatrix(matrix);
                        continue;
                    }
                }
                Console.WriteLine("Invalid input!");
            }
        }
        static void PrintMatrix(string[,] matrix)
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
        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(' ').ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }

            }
            return matrix;
        }
    }
}
