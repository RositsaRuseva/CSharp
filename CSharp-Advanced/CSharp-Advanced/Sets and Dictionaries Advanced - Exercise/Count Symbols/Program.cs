using System;
using System.Linq;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            var dict = new SortedDictionary<char, int>();
            foreach (var symbol in inputText)
            {
                if(!dict.ContainsKey(symbol))
                {
                    dict.Add(symbol, 0);
                }
                dict[symbol]++;
            }
            foreach (var symbol in dict)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
