using System;

namespace ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int manCount = int.Parse(Console.ReadLine());
            int womanCount = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            int tablesCount = 0;

            for (int x1 = 1; x1 <= manCount; x1++)
            {
                for (int x2 = 1; x2 <= womanCount; x2++)
                {
                    
                    if (tables != 0)
                    {
                        Console.Write($"({x1} <-> {x2}) ");
                        tables--;
                    }
                    
                }
            }
        }
    }
}
