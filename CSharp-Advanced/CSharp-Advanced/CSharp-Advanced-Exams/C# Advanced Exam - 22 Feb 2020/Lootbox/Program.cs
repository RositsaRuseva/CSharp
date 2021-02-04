using System;
using System.Linq;
using System.Collections.Generic;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstLoot = new Queue<int>(firstInput);
            var secondLoot = new Stack<int>(secondInput);
            var claimed = new List<int>();
            while (true)
            {


                int sum = firstLoot.Peek() + secondLoot.Peek();
                //var claimed = new List<int>();

                if (sum % 2 == 0)
                {
                    claimed.Add(sum);
                    //firstLoot.Dequeue();
                    //secondLoot.Pop();
                }
                else
                {
                    firstLoot.Enqueue(secondLoot.Pop());
                   // secondLoot.Pop();
                }
                if (firstLoot.Count == 0)
                {
                    Console.WriteLine("First lootbox is empty");
                    break;
                }
                if (secondLoot.Count == 0)
                {
                    Console.WriteLine("Second lootbox is empty");
                    break;
                }
            }
            if (firstLoot.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (secondLoot.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (claimed.Sum() >= 100 )
            {
                Console.WriteLine($"Your loot was epic! Value: {claimed.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimed.Sum()}");
            }
        }
    }
}
