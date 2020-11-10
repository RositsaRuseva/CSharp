using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

           // bool isEqual = true;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }
                for (int k = i +1 ; k < array.Length; k++)
                {
                    rightSum += array[k];
                }
                if(leftSum == rightSum)
                {
                    //isEqual = true;
                    Console.WriteLine(i);
                    return;
                }
               // else
                //{
                  //  Console.WriteLine("no");
                //}
            }
           
          
                Console.WriteLine("no");
            
        }
    }
}
