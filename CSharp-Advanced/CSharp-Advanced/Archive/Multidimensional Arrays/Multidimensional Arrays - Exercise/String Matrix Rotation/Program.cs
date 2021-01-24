using System;
using System.Linq;
using System.Collections.Generic;

namespace StringMatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            int degrees = int.Parse(command[1]);
            int rotate = degrees % 360;

            List<List<char>> matrix = GetInput();
            FillMatrixWithSpaces(matrix);

            switch (rotate)
            {
                case 0:
                    PrintRotation0(matrix);
                    break;
                case 90:
                    PrintRotation90(matrix);
                    break;

                case 180:
                    PrintRotation180(matrix);
                    break;
                case 270:
                    PrintRotation270(matrix);
                    break;
            }

        }
        private static void PrintRotation270(List<List<char>> matrix)
        {
            for (int col = matrix[0].Count -1; col >= 0; col--)
            {
                for (int row = 0; row < matrix.Count; row++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }
        private static void PrintRotation180(List<List<char>> matrix)
        {
            for (int row = matrix.Count-1; row >= 0; row--)
            {
                for (int col = matrix[0].Count-1; col >= 0; col--)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }
        private static void PrintRotation90(List<List<char>> matrix)
        {
            for (int col = 0; col < matrix[0].Count; col++)
            {
                for (int row = matrix.Count -1; row >= 0; row--)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }
        private static void PrintRotation0(List<List<char>> matrix)
        {
            foreach (var line in matrix)
            {
                Console.WriteLine(string.Join(string.Empty, line));
            }
        }
        private static void FillMatrixWithSpaces (List<List<char>> matrix)
        {
            int maxLength = matrix.Max(x => x.Count);
            foreach (var list in matrix)
            {
                if (list.Count < maxLength)
                {
                    for (int i = list.Count; i < maxLength; i++)
                    {
                        list.Add(' ');
                    }
                }
            }
        }
        private static List<List<char>> GetInput()
        {
            List<List<char>> matrix = new List<List<char>>();
            string input = Console.ReadLine();
            while (input!= "END")
            {
                matrix.Add(input.ToCharArray().ToList());
                input = Console.ReadLine();
            }
            return matrix;
        }
    }
}
