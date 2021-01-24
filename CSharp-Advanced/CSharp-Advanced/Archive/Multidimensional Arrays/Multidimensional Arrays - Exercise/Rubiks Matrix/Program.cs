using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace matrixCubes
{
    class Program
    {
        static void Main()
        {
            var size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = FillMatrix(size);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commands = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                OperationManager(commands, matrix);

            }

            ReArrangeManager(matrix);
        }

        private static void ReArrangeManager(int[,] matrix)
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var value = row * matrix.GetLength(1) + col + 1;
                    if (matrix[row, col] == value)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        var position = FindValuePosition(value, matrix);
                        var currentPosition = new int[2];

                        currentPosition[0] = row;
                        currentPosition[1] = col;

                        Console.WriteLine($"Swap ({row}, {col}) with ({position[0]}, {position[1]})");
                        SwapValues(matrix, currentPosition, position);
                    }
                }
            }


        }

        private static void SwapValues(int[,] matrix, int[] currentPosition, int[] position)
        {
            var tempValue = matrix[currentPosition[0], currentPosition[1]];

            matrix[currentPosition[0], currentPosition[1]] = matrix[position[0], position[1]];
            matrix[position[0], position[1]] = tempValue;


        }

        private static int[] FindValuePosition(int value, int[,] matrix)
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == value)
                    {
                        var indexes = new int[2];
                        indexes[0] = row;
                        indexes[1] = col;
                        return indexes;
                    }
                }
            }
            return null;
        }

        private static void OperationManager(string[] commands, int[,] matrix)
        {
            var direction = commands[1];

            switch (direction)
            {
                case "right":
                    MoveRight(commands, matrix);
                    break;
                case "left":
                    MoveLeft(commands, matrix);
                    break;
                case "up":
                    MoveUp(commands, matrix);
                    break;
                case "down":
                    MoveDown(commands, matrix);
                    break;
            }



        }

        private static void MoveDown(string[] commands, int[,] matrix)
        {
            int moves = int.Parse(commands[2]);

            int col = int.Parse(commands[0]);
            


            for (int i = 0; i < moves; i++)
            {
                var last = matrix[matrix.GetLength(0) - 1, col];

                for (int row = matrix.GetLength(0) - 1; row > 0; row--)
                {
                    matrix[row, col] = matrix[row - 1, col];
                }
                matrix[0, col] = last;
            }

            


        }

        private static void MoveUp(string[] commands, int[,] matrix)
        {
            int moves = int.Parse(commands[2]);

            int col = int.Parse(commands[0]);
           
            for (int j = 0; j < moves; j++)
            {
                var first = matrix[0, col];

                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    matrix[i, col] = matrix[i + 1, col];
                }
                matrix[matrix.GetLength(0) - 1, col] = first;

            }



        }

        private static void MoveLeft(string[] commands, int[,] matrix)
        {
            int moves = int.Parse(commands[2]);
            int row = int.Parse(commands[0]);

            int[] tempArray = new int[matrix.GetLongLength(0)];
            
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                tempArray[col] = matrix[row, col];
            }
            

            for (int i = 0; i < moves; i++)
            {
                
                int first = tempArray[0];
                
                for (int z = 0; z < tempArray.Length - 1; z++)
                {
                    tempArray[z] = tempArray[z + 1];
                }
                tempArray[tempArray.Length - 1] = first;
            }
            
            for (int col = 0; col < matrix.GetLongLength(1); col++)
            {
                matrix[row, col] = tempArray[col];
            }
        }

        private static void MoveRight(string[] commands, int[,] matrix)
        {
            int moves = int.Parse(commands[2]);
            int row = int.Parse(commands[0]);

            int[] tempArray = new int[matrix.GetLongLength(0)];
            
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                tempArray[col] = matrix[row, col];
            }
            

            for (int i = 0; i < moves; i++)
            {
                
                int last = tempArray[tempArray.Length - 1];
                for (int z = tempArray.Length - 1; z > 0; z--)
                {
                    tempArray[z] = tempArray[z - 1];
                }
                tempArray[0] = last;
            }
            
            for (int col = 0; col < matrix.GetLongLength(1); col++)
            {
                matrix[row, col] = tempArray[col];
            }
        }

        private static int[,] FillMatrix(int[] size)
        {
            int rows = size[0];
            int columns = size[1];

            var matrix = new int[rows, columns];

            int counter = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = counter;
                    counter++;
                }
            }

            return matrix;
        }
    }
}
