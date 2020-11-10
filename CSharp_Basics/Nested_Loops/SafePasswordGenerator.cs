using System;

namespace SafePasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxGeneratedPasswords = int.Parse(Console.ReadLine());

            int currentCount = 0;
            int x1 = 35;
            int x2 = 64;

            for (int dig1 = 1; dig1 <= a; dig1++)
            {
                for (int dig2 = 1; dig2 <= b; dig2++)
                {
                    currentCount++;

                    Console.Write($"{(char)x1}{(char)x2}{dig1}{dig2}{(char)x2}{(char)x1}|");

                    x1++;
                    x2++;

                    if (x1 > 55)
                    {
                        x1 = 35;
                    }
                    if (x2 > 96)
                    {
                        x2 = 64;
                    }
                    if(currentCount == maxGeneratedPasswords)
                    {
                        break;
                    }
                }
                if (currentCount == maxGeneratedPasswords)
                {
                    break;
                }
            }
        }
    }
}
