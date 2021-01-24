using System;
using System.Linq;

namespace TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse).ToArray();
            string snake = Console.ReadLine();

            char[,] matrix = new char[size[0], size[1]];

            int currentLetter = 0;
            bool rightToLeft = true;
            FillMatrix(size, snake, matrix, ref currentLetter, ref rightToLeft);

            int[] shotParameters = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();

            int shotRow = shotParameters[0];
            int shotColumn = shotParameters[1];
            int shotRadius = shotParameters[2];
            ShootMatrix(matrix, shotRow, shotColumn, shotRadius);
            CheckForWhiteSpace(size, matrix);
            PrintMatrix(matrix);

        }

        private static void CheckForWhiteSpace(int[] size, char[,] matrix)
        {
            for (int i = 0; i < size[1]; i++)
            {
                for (int j = 0; j < size[0]; j++)
                {
                    for (int k = size[0] - 1; k > 0; k--)
                    {


                        if (matrix[k, i] == ' ')
                        {
                            matrix[k, i] = matrix[k - 1, i];
                            matrix[k - 1, i] = ' ';
                        }
                    }
                }
            }
        }

        private static void ShootMatrix(char[,] matrix, int shotRow, int shotColumn, int shotRadius)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - shotRow, 2) + Math.Pow(col - shotColumn, 2));
                    if (distance <= shotRadius)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }
        }

        private static void FillMatrix(int[] size, string snake, char[,] matrix, ref int currentLetter, ref bool rightToLeft)
        {
            for (int row = size[0] - 1; row >= 0; row--)
            {
                if (rightToLeft)
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
                else
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
                rightToLeft = !rightToLeft;
            }
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
    }
}
