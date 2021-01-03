using System;
using System.Linq;
using System.Collections.Generic;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = ReadMatrix(n, n);

            int countReplaced = 0;
            int rowKiller = 0;
            int colKiller = 0;
            while (true)
            {
                int maxAttacks = 0;
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        int countAttacks = 0;
                        char currentSymbol = matrix[row, col];
                        
                        if(currentSymbol == 'K')
                        {
                            countAttacks = GetAttacks(matrix, row, col, countAttacks);
                        
                            if(countAttacks > maxAttacks)
                            {
                                maxAttacks = countAttacks;
                                rowKiller = row;
                                colKiller = col;
                            }
                        }
                    }
                }
                if(maxAttacks > 0)
                {
                    matrix[rowKiller, colKiller] = '0';
                    countReplaced++;
                }



                else
                {
                    Console.WriteLine(countReplaced);
                    break;
                }
            }
        }

        private static int GetAttacks(char[,] matrix, int row, int col, int countAttacks)
        {
            if (IsInside(matrix, row - 2, col + 1)
                                            && matrix[row - 2, col + 1] == 'K')
            {

                countAttacks++;
            }
            if (IsInside(matrix, row - 2, col - 1)
                && matrix[row - 2, col - 1] == 'K')
            {

                countAttacks++;
            }
            if (IsInside(matrix, row + 1, col + 2)
                && matrix[row + 1, col + 2] == 'K')
            {

                countAttacks++;
            }
            if (IsInside(matrix, row + 1, col - 2)
                && matrix[row + 1, col - 2] == 'K')
            {

                countAttacks++;
            }
            if (IsInside(matrix, row - 1, col + 2)
                && matrix[row - 1, col + 2] == 'K')
            {

                countAttacks++;
            }
            if (IsInside(matrix, row - 1, col - 2)
                && matrix[row - 1, col - 2] == 'K')
            {

                countAttacks++;
            }
            if (IsInside(matrix, row + 2, col - 1)
                && matrix[row + 2, col - 1] == 'K')
            {

                countAttacks++;
            }
            if (IsInside(matrix, row + 2, col + 1)
                && matrix[row + 2, col + 1] == 'K')
            {

                countAttacks++;
            }

            return countAttacks;
        }

        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }

            }
            return matrix;
        }
        static bool IsInside(char[,] matrix, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < matrix.GetLength(0)
                && targetCol >= 0 && targetCol < matrix.GetLength(1);
        }
    }
}
