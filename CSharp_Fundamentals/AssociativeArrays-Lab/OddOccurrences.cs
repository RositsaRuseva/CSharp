using System;
using System.Linq;
using System.Collections.Generic;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsCollection = Console.ReadLine()
                .ToLower()
                .Split(' ');

            var wordsDict = new Dictionary<string, int>();
            foreach (var word in wordsCollection)
            {
                if (!wordsDict.ContainsKey(word))
                {
                    wordsDict[word] = 0;
                }
                wordsDict[word]++;
            }

            var wordsList = wordsDict
                .Where(w => w.Value % 2 == 1)
                .Select(w => w.Key)
                .ToList();

            Console.WriteLine(string.Join(" ", wordsList));
        }
    }
}
