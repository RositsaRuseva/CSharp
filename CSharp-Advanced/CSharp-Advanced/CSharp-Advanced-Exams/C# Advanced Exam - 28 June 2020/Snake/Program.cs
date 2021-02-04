using System;
using System.Linq;
using System.Collections.Generic;

namespace SnakeExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int row = 0;
            int col = 0;
            int food = 0;

           // List<int> list = new List<int>();
            ReadMatrix(n, matrix, ref row, ref col);

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    matrix[row, col] = '.'; // leaving mark;
                    row = row - 1; //moving
                    if (row >=0) //stays in matrix
                    {
                        SnakeMoves(n, matrix, ref row, ref col, ref food);
                    }
                    else
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        break;
                    }
                }
                if (command == "down")
                {
                    matrix[row, col] = '.';
                    row = row + 1;
                    if (row<n)
                    {
                        SnakeMoves(n, matrix, ref row, ref col, ref food);
                    }
                    else
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        break;
                    }
                   
                }
                if (command == "left")
                {
                    matrix[row, col] = '.';
                    col = col - 1;
                    if (col >= 0)
                    {
                        SnakeMoves(n, matrix, ref row, ref col, ref food);
                    }
                    else
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        break;
                    }
                }
                if (command == "right")
                {
                    matrix[row, col] = '.';
                    col = col + 1;
                    if (col<n)
                    {
                        SnakeMoves(n, matrix, ref row, ref col, ref food);
                    }
                    else
                    {
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        break;
                    }
                }
                if (food>= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    Console.WriteLine($"Food eaten: {food}");
                    matrix[row, col] = 'S';
                    break;
                }
            }
            PrintMatrix(n, matrix);
        }

        private static void PrintMatrix(int n, char[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static void SnakeMoves (int n, char[,] matrix, ref int row, ref int col, ref int food)
        {
            if (matrix[row,col] == '*') //food
            {
                food++;
                matrix[row, col] = '.';
            }
            else if (matrix[row,col] == 'B') //Burrow
            {
                matrix[row, col] = '.';
                for (int rows = 0; rows < n; rows++)
                {
                    for (int cols = 0; cols < n; cols++)
                    {


                        if (matrix[rows, cols] == 'B')
                        {
                            matrix[rows, cols] = '.';
                            row = rows;
                            col = cols;
                        }
                    }
                }
            }
        }
        private static void ReadMatrix(int n, char[,] matrix, ref int row, ref int col)
        {
            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'S')
                    {
                        row = rows;
                        col = cols;
                    }
                }
            }
        }
    }
}
