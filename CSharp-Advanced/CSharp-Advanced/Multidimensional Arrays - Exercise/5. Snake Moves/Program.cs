using System;
using System.Linq;
using System.Collections.Generic;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string snake = Console.ReadLine();

            char[,] matrix = new char[size[0], size[1]];
            int currentLetter = 0;
            for (int row = 0; row < size[0]; row++)
            {
                if (row % 2 == 0)
                {


                    for (int col = 0; col < size[1]; col++)
                    {
                        matrix[row, col] = snake[currentLetter];
                        currentLetter++;
                        if (currentLetter == snake.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }
                else
                {
                    for (int col = size[1] - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[currentLetter];
                        currentLetter++;
                        if (currentLetter == snake.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }
            }
            PrintMatrix(matrix);

        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {using System;
using System.Linq;
using System.Collections.Generic;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string snake = Console.ReadLine();

            char[,] matrix = new char[size[0], size[1]];
            int currentLetter = 0;
            for (int row = 0; row < size[0]; row++)
            {
                if (row % 2 == 0)
                {


                    for (int col = 0; col < size[1]; col++)
                    {
                        matrix[row, col] = snake[currentLetter];
                        currentLetter++;
                        if (currentLetter == snake.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }
                else
                {
                    for (int col = size[1] - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[currentLetter];
                        currentLetter++;
                        if (currentLetter == snake.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }
            }
            PrintMatrix(matrix);

        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "");
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


                    Console.Write(matrix[row, col] + "");
                }
                Console.WriteLine();
            }
            // Console.WriteLine();
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

