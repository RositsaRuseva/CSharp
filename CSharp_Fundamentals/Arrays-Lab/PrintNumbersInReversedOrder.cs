using System;

namespace PrintNumberInReversedOrderArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                
                array[i] = int.Parse(Console.ReadLine());

            }
            Array.Reverse(array);

            foreach (int value in array)
            {


                Console.Write(value + " ");
            }
        }
    }
}
