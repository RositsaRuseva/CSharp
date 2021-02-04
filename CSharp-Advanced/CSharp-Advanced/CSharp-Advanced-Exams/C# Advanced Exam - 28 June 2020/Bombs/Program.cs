using System;
using System.Linq;
using System.Collections.Generic;

namespace BombsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine()
                .Split(", ").Select(int.Parse).ToArray();
            int[] secondInput = Console.ReadLine()
                .Split(", ").Select(int.Parse).ToArray();

            var bombEffect = new Queue<int>(firstInput);
            var bombCasing = new Stack<int>(secondInput);

            

            int daturaCounter = 0;
            int cherryCounter = 0;
            int smokeDecoyCounter = 0;
            bool allBombs = false;

            while (bombCasing.Count > 0 && bombEffect.Count > 0)
            {
                int sum = bombEffect.Peek() + bombCasing.Peek();
                if (sum == 40)
                {
                    daturaCounter++;
                    bombCasing.Pop();
                    bombEffect.Dequeue();
                }
                else if (sum == 60)
                {
                    cherryCounter++;
                    bombCasing.Pop();
                    bombEffect.Dequeue();
                }
                else if (sum == 120)
                {
                    smokeDecoyCounter++;
                    bombCasing.Pop();
                    bombEffect.Dequeue();
                }
                else
                {
                    bombCasing.Pop();
                    bombCasing.Push(bombCasing.Peek() - 5);
                }
                if (daturaCounter >= 3 && cherryCounter >= 3 && smokeDecoyCounter >= 3)
                {
                    allBombs = true;
                    break;
                }
            }
            if (allBombs)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (bombEffect.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else if (bombEffect.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(",",bombEffect)}");
            }
            if (bombCasing.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else if (bombCasing.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");

            }
            
            Console.WriteLine($"Cherry Bombs: {cherryCounter}");
            Console.WriteLine($"Datura Bombs: {daturaCounter}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyCounter}");
            

        }
    }
}
