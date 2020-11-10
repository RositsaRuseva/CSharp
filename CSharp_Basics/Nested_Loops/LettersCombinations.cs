using System;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            int counter = 0;

            for (char x1 = firstLetter; x1 <= secondLetter; x1++)
            {
                for (char x2 = firstLetter; x2 <= secondLetter; x2++)
                {
                    for (char x3 = firstLetter; x3 <= secondLetter; x3++)
                    {
                        if(x1 == thirdLetter || x2 == thirdLetter || x3 == thirdLetter)
                        {
                            continue;
                        }
                        else
                        {
                            counter++;
                            Console.Write($"{x1}{x2}{x3} ");
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
