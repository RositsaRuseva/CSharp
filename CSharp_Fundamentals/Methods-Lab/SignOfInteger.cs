using System;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace SignOfIntegerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //string output = string.Empty;
            SignOfInteger(n);
        }

        static void SignOfInteger(int n)
        {
           // string output = string.Empty;
            if(n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
                //output = "positive";
            }
            else if(n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
                //output = "negative";
            }
            else if(n == 0)
            {
                //output = "zero";
                Console.WriteLine($"The number {n} is zero.");
            }
            //Console.WriteLine($"The number {n} is {output}.");
        }
    }
}
