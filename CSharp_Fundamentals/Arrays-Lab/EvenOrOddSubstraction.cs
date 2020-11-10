using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumOdd = 0;
            int sumEven = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if(currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else
                {
                    sumOdd += currentNumber;
                }
            }
           

            
            
            int difference = sumEven - sumOdd;
            Console.WriteLine(difference);
        }
    }
}
