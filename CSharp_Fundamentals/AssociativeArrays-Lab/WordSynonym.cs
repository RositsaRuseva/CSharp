using System;
using System.Linq;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                
                if(words.ContainsKey(word))
                {
                    words[word].Add(synonym);
                }
                else
                {
                    words.Add(word, new List<string>());
                    words[word].Add(synonym);
                }
            }
            foreach (var pair in words)
            {
                Console.WriteLine(pair.Key + " - " + string.Join(", ", pair.Value));
            }
        }
    }
}
