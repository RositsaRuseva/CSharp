using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Program
    {
        const int bread = 25;
        const int cake = 50;
        const int pastry = 75;
        const int fruitPie = 100;

        

        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();
            int[] secondInput = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();

            var liquids = new Queue<int>(firstInput);
            var ingredients = new Stack<int>(secondInput);

            int breadCount = 0;
            int cakeCount = 0;
            int pastryCount = 0;
            int fruitPieCount = 0;

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                Operations(liquids, ingredients, ref breadCount, ref cakeCount, ref pastryCount, ref fruitPieCount);
            }
            Succeeded(breadCount, cakeCount, pastryCount, fruitPieCount);

            if (liquids.Count > 0)
            {
                Console.Write("Liquids left: ");
                Console.WriteLine(String.Join(", ", liquids));
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }
            if (ingredients.Count > 0)
            {
                Console.Write("Ingredients left: ");
                Console.WriteLine(String.Join(", ", ingredients));
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            Console.WriteLine($"Bread: {breadCount}");
            Console.WriteLine($"Cake: {cakeCount}");
            Console.WriteLine($"Fruit Pie: {fruitPieCount}");
            Console.WriteLine($"Pastry: {pastryCount}");

        }

        private static void Succeeded(int breadCount, int cakeCount, int pastryCount, int fruitPieCount)
        {
            if (breadCount > 0 && cakeCount > 0
                            && pastryCount > 0 && fruitPieCount > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
        }

        private static void Operations(Queue<int> liquids, Stack<int> ingredients, ref int breadCount, ref int cakeCount, ref int pastryCount, ref int fruitPieCount)
        {
            int sum = liquids.Peek() + ingredients.Peek();
            if (sum == bread)
            {
                breadCount++;
                liquids.Dequeue();
                ingredients.Pop();
            }

            else if (sum == cake)
            {
                cakeCount++;
                liquids.Dequeue();
                ingredients.Pop();

            }

            else if (sum == pastry)
            {
                pastryCount++;
                liquids.Dequeue();
                ingredients.Pop();

            }

            else if (sum == fruitPie)
            {
                fruitPieCount++;
                liquids.Dequeue();
                ingredients.Pop();

            }
            else
            {
                liquids.Dequeue();
                int value = ingredients.Pop() + 3;
                ingredients.Push(value);
            }
        }
    }
}
