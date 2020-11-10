using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    sum = array[i] + array[j];
                    if (sum == n)
                    {
                        //Console.WriteLine(sum);
                        Console.WriteLine("{0} {1} ", array[i], array[j]);


                    }
                }
                //sum = array[i] + array[i + 1];

               
            }
            
        }
    }
}
