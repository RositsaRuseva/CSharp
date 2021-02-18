using System;
using System.Linq;
using System.Collections.Generic;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int row = 0;
            int col = 0;

            ReadMatrix(n, matrix, ref row, ref col);

            int money = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    if (row-1>=0)
                    {
                        if (matrix[row-1,col] == '-')
                        {
                            matrix[row - 1, col] = 'S';
                            matrix[row, col] = '-';
                            row -= 1;
                        }
                        else if (Char.IsDigit(matrix[row-1,col]))
                        {
                            money += int.Parse(matrix[row - 1, col].ToString());
                            matrix[row - 1, col] = 'S';
                            matrix[row, col] = '-';
                            row -= 1;
                        }
                        else if (matrix[row-1,col] == 'O')
                        {
                            matrix[row - 1, col] = '-';
                            matrix[row, col] = '-';
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i,j] == 'O')
                                    {
                                        matrix[i, j] = 'S';
                                        row = i;
                                        col = j;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        matrix[row, col] = '-';
                        break;
                    }
                }
                if (command == "down")
                {
                    if (row+1 < n)
                    {
                        if (matrix[row+1, col] == '-')
                        {
                            matrix[row + 1, col] = 'S';
                            matrix[row, col] = '-';
                            row += 1;
                        }
                        else if (Char.IsDigit(matrix[row+1,col]))
                        {
                            money += int.Parse(matrix[row + 1, col].ToString());
                            matrix[row + 1, col] = 'S';
                            matrix[row, col] = '-';
                            row += 1;
                        }
                        else if (matrix[row+1,col] == 'O')
                        {
                            matrix[row + 1, col] = '-';
                            matrix[row, col] = '-';
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i,j] == 'O')
                                    {
                                        matrix[i, j] = 'S';
                                        row = i;
                                        col = j;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        matrix[row, col] = '-';
                        break;
                    }
                }
                if (command == "left")
                {
                    if (col-1>= 0)
                    {
                        if (matrix[row,col-1] == '-')
                        {
                            matrix[row, col - 1] = 'S';
                            matrix[row, col] = '-';
                            col -= 1;
                        }
                        else if (Char.IsDigit(matrix[row,col-1]))
                        {
                            money += int.Parse(matrix[row, col - 1].ToString());
                            matrix[row, col - 1] = 'S';
                            matrix[row, col] = '-';
                            col -= 1;
                        }
                        else if (matrix[row,col-1] == 'O')
                        {
                            matrix[row, col - 1] = '-';
                            matrix[row, col] = '-';
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i,j] == 'O')
                                    {
                                        matrix[i, j] = 'S';
                                        row = i;
                                        col = j;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        matrix[row, col] = '-';
                        break;
                    }
                }
                if (command == "right")
                {
                    if (col+1<n)
                    {
                        if (matrix[row,col+1] == '-')
                        {
                            matrix[row, col + 1] = 'S';
                            matrix[row, col] = '-';
                            col += 1;
                        }
                        else if (Char.IsDigit(matrix[row,col+1]))
                        {
                            money += int.Parse(matrix[row, col + 1].ToString());
                            matrix[row, col + 1] = 'S';
                            matrix[row, col] = '-';
                            col += 1;
                        }
                        else if (matrix[row,col+1] == 'O')
                        {
                            matrix[row, col + 1] = '-';
                            matrix[row, col] = '-';
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i,j] == 'O')
                                    {
                                        matrix[i, j] = 'S';
                                        row = i;
                                        col = j;

                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        matrix[row, col] = '-';
                        break;
                    }
                }
                if (money >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    break;
                }
            }
            Console.WriteLine($"Money: {money}");
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
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
