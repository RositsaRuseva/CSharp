using System;
using System.Linq;

namespace Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split("|").Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            int points = 0;

            while (command != "Game over")
            {
                string[] receivedCommand = command.Split("@");
                string firstPartOfCommand = receivedCommand[0];

                if (firstPartOfCommand == "Shoot Left")
                {
                    int startIndex = int.Parse(receivedCommand[1]);
                    int length = int.Parse(receivedCommand[2]);

                    if (startIndex >= 0 & startIndex < targets.Length)
                    {
                        length %= targets.Length;

                        int offset = targets.Length - length;

                        int targetIndex = (startIndex + offset) % targets.Length;

                        if (targets[targetIndex] <= 5)
                        {
                            points += targets[targetIndex];
                            targets[targetIndex] = 0;
                        }
                        else
                        {
                            points += 5;
                            targets[targetIndex] -= 5;
                        }
                    }
                }
                else if (firstPartOfCommand == "Shoot Right")
                {
                    int startIndex = int.Parse(receivedCommand[1]);
                    int length = int.Parse(receivedCommand[2]);

                    if (startIndex >= 0 & startIndex < targets.Length)
                    {
                        int targetIndex = (startIndex + length) % targets.Length;

                        if (targets[targetIndex] <= 5)
                        {
                            points += targets[targetIndex];
                            targets[targetIndex] = 0;
                        }
                        else
                        {
                            points += 5;
                            targets[targetIndex] -= 5;
                        }
                    }
                }
                else if (firstPartOfCommand == "Reverse")
                {
                    Array.Reverse(targets);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" - ", targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}