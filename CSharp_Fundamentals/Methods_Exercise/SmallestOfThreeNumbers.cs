using System;
using System.Linq;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintTheSmallestNumber(n1, n2, n3));
        }

        private static int PrintTheSmallestNumber(int n1, int n2, int n3)
        {
            int result = 0;
            // int[] array = new int[3];
            ///for (int i = 0; i < 3; i++)
            //{
            //  array[i] = int.Parse(Console.ReadLine());
            //}
            //return array.Min;
            if (n1 <= n2 && n1 <= n3)
            {
                result = n1;
            }
            else if (n2 <= n1 && n2 <= n3)
            {
                result = n2;
            }
            else if (n3 <= n1 && n3 <= n2)
            {
                result = n3;
            }
            return result;
        }
    }
}
