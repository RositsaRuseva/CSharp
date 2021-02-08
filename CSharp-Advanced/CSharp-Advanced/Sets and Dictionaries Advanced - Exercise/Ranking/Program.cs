using System;
using System.Linq;
using System.Collections.Generic;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var nameAndContestWithPoints = new SortedDictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "end of contests")
                {
                    break;
                }
                List<string> contestsInfo = input.Split(":").ToList();

                string name = contestsInfo[0];
                string password = contestsInfo[1];

                contests.Add(name, password);

            }
            while (true)
            {
                string inputCollection = Console.ReadLine();
                if(inputCollection == "end of submissions")
                {
                    break;
                }
                List<string> submissions = inputCollection.Split("=>").ToList();
                string contest = submissions[0];
                string password = submissions[1];
                string name = submissions[2];
                int points = int.Parse(submissions[3]);
                if(contests.ContainsKey(contest) && contests.ContainsValue(password))
                {
                    if(!nameAndContestWithPoints.ContainsKey(name))
                    {
                        nameAndContestWithPoints.Add(name, new Dictionary<string, int>());
                        nameAndContestWithPoints[name].Add(contest, points);
                    }
                    if(nameAndContestWithPoints[name].ContainsKey(contest))
                    {
                        if (nameAndContestWithPoints[name][contest] < points)
                        {
                            nameAndContestWithPoints[name][contest] = points;
                        }
                    }
                    else
                    {
                        nameAndContestWithPoints[name].Add(contest, points);
                    }
                }

            }
            var usernameTotalPoints = new Dictionary<string, int>();
            foreach (var kvp in nameAndContestWithPoints)
            {
                usernameTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }
            string bestName = usernameTotalPoints.Keys.Max();
            int bestPoints = usernameTotalPoints.Values.Max();

            foreach (var kvp in usernameTotalPoints)
            {
                if(kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
                }
            }
            Console.WriteLine("Ranking: ");
            foreach (var name in nameAndContestWithPoints)
            {
                Dictionary<string, int> dict = name.Value;
                dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine($"{name.Key}");
                foreach (var kvp in dict)
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
