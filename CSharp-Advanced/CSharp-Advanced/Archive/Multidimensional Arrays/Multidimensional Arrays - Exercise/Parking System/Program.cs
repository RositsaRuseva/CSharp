using System;
using System.Linq;
using System.Collections.Generic;
namespace ParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split();
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);

            byte[][] matrix = new byte[rows][];

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "stop")
            {
                string[] input = command.Split();

                int entrance = int.Parse(input[0]);
                int parkingRow = int.Parse(input[1]);
                int parkingCol = int.Parse(input[2]);

                int steps = Math.Abs(entrance - parkingRow) + 1;

                if (matrix[parkingRow] == null)
                {
                    matrix[parkingRow] = new byte[cols];
                }
                if (matrix[parkingRow][parkingCol] == 0)
                {
                    matrix[parkingRow][parkingCol] = 1;
                    steps += parkingCol;
                    Console.WriteLine(steps);
                }
                else
                {
                    int count = 1;
                    while (true)
                    {
                        int lowerCell = parkingCol - count;
                        int upperCell = parkingCol + count;

                        if (lowerCell < 1 && upperCell > cols - 1) // out of bound
                        {
                            Console.WriteLine($"Row {parkingRow} full");
                            break;
                        }
                        if (lowerCell > 0 && matrix[parkingRow][lowerCell] == 0)//inside the row and free
                        {
                            matrix[parkingRow][lowerCell] = 1;
                            steps += lowerCell;
                            Console.WriteLine(steps);
                            break;
                        }
                        if (upperCell < cols && matrix[parkingRow][upperCell] == 0)
                        {
                            matrix[parkingRow][upperCell] = 1;
                            steps += upperCell;
                            Console.WriteLine(steps);
                            break;
                        }
                        count++;
                    }
                }
            }
        }
    }
}
