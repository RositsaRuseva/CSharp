using System;

namespace OddEvenPosition1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;

            double oddSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;

            if (n == 0)
            {
                Console.WriteLine("OddSum=0.00,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else 
            {
                for (int i = 1; i <= n; i++)
                {
                    double number = double.Parse(Console.ReadLine());

                    if (i % 2 == 1)
                    {
                        oddSum += number;

                        if (number > oddMax)
                        {
                            oddMax = number;
                        }
                        if (number < oddMin)
                        {
                            oddMin = number;
                        }
                    }
                    else
                    {
                        evenSum += number;
                        if (number > evenMax)
                        {
                            evenMax = number;
                        }
                        if (number < evenMin)
                        {
                            evenMin = number;
                        }
                    }



                }
                if (n > 1)
                {
                    Console.WriteLine($"OddSum={oddSum:f2},");
                    Console.WriteLine($"OddMin={oddMin:f2},");
                    Console.WriteLine($"OddMax={oddMax:f2},");
                    Console.WriteLine($"EvenSum={evenSum:f2},");
                    Console.WriteLine($"EvenMin={evenMin:f2},");
                    Console.WriteLine($"EvenMax={evenMax:f2}");
                }
                if (n == 1)
                {
                    
                        Console.WriteLine($"OddSum={oddSum:f2},");
                        Console.WriteLine($"OddMin={oddMin:f2},");
                        Console.WriteLine($"OddMax={oddMax:f2},");
                        Console.WriteLine($"EvenSum=0.00,");
                        Console.WriteLine($"EvenMin=No,");
                        Console.WriteLine($"EvenMax=No");
                    
                }
            }

        }
    }
}
