using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> input = Console.ReadLine().Split().Select(long.Parse).ToList();
            // List<long> input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(long.Parse).ToList();

            //int index = int.Parse(Console.ReadLine());
            long sum = (long)0;

            while (input.Count > 0)
            {

                long number = (long)0;
                int index = int.Parse(Console.ReadLine());


                if (index > input.Count - 1)
                {
                    number = input.Last();
                    sum += (long)number;
                    input[input.Count - 1] = input[0];
                }
                else if (index < 0)
                {
                    number = input[0];
                    sum += (long)number;
                    input[0] = input[input.Count - 1];


                }

                else
                {
                    number = input[index];
                    sum += (long)number;
                    input.RemoveAt(index);
                }

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= number)
                    {
                        input[i] += number;
                    }
                    else
                    {
                        input[i] -= number;
                    }
                }
                //index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }

    }
}
