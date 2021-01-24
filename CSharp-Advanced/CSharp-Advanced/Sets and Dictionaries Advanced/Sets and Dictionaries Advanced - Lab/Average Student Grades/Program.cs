using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ").ToArray();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if(!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<decimal>());
                    dict[name].Add(grade);
                }
                else
                {
                    dict[name].Add(grade);
                }
            }
            foreach (var pair in dict)
            {
                StringBuilder allGrades = new StringBuilder();
                for (int i = 0; i < pair.Value.Count; i++)
                {
                    allGrades.Append($"{pair.Value[i]:f2} ");
                }
                Console.WriteLine($"{pair.Key} -> {allGrades.ToString()}(avg: {pair.Value.Average():f2})");
            }
        }
    }
}
