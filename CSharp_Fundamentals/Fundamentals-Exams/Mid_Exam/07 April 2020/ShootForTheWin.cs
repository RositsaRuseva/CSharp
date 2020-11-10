using System;
using System.Linq;
using System.Collections.Generic;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string input = Console.ReadLine();
            int counter = 0;

            while (input != "End")
            {
                int shot = int.Parse(input);
                if (shot >= 0 && shot <= list.Count - 1)
                {
                    int temp = list[shot];
                    list[shot] = -1;
                    counter++;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] != -1 && i != shot)
                        {
                            if (list[i] > temp)
                            {
                                list[i] -= temp;
                            }
                            else if (list[i] <= temp)
                            {
                                list[i] += temp;
                            }
                        }

                    }


                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {counter} -> " + "" + string.Join(" ", list));
        }
    }
}