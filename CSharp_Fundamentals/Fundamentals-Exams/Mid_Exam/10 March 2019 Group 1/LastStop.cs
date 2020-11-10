using System;
using System.Linq;
using System.Collections.Generic;

namespace LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintingNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] input = command.Split(" ").ToArray();
                string operation = input[0];

                switch (operation)
                {
                    case "Change":
                        {
                            int paintingNumber = int.Parse(input[1]);
                            int changedNumber = int.Parse(input[2]);
                            if (paintingNumbers.Contains(paintingNumber))
                            {
                                int temp1 = paintingNumbers.IndexOf(paintingNumber);
                                
                                paintingNumbers[temp1] = changedNumber;
                               
                            }
                        }
                        break;
                    case "Hide":
                        {
                            int paintingNumber = int.Parse(input[1]);
                            if(paintingNumbers.Contains(paintingNumber))
                            {
                                int temp1 = paintingNumbers.IndexOf(paintingNumber);
                                paintingNumbers.RemoveAt(temp1);
                            }
                        }
                        break;
                    case "Switch":
                        {
                            int paintingNumber = int.Parse(input[1]);
                            int paintingNumber2 = int.Parse(input[2]);
                            if(paintingNumbers.Contains(paintingNumber) && paintingNumbers.Contains(paintingNumber2))
                            {
                                int temp1 = paintingNumbers.IndexOf(paintingNumber);
                                int temp2 = paintingNumbers.IndexOf(paintingNumber2);
                               // int temp1 = paintingNumbers[paintingNumber];
                                //int temp2 = paintingNumbers[paintingNumber2];

                                paintingNumbers[temp1] = paintingNumber2;
                                paintingNumbers[temp2] = paintingNumber;
                            }

                        }
                        break;
                    case "Insert":
                        {
                            int place = int.Parse(input[1]) + 1;
                            int paintingNumber = int.Parse(input[2]);
                            if (place > 0 && place < paintingNumbers.Count)
                            { 
                                paintingNumbers.Insert(place, paintingNumber);
                            }
                        }
                        break;
                    case "Reverse":
                        {
                            paintingNumbers.Reverse();
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",paintingNumbers));
        }
    }
}
