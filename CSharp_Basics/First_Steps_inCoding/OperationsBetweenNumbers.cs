using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            string evenOrOdd = string.Empty;
            double result = 0.0;

            if (operation == '+')
            {
                result = N1 + N2;
                if (result % 2 == 0)
                { evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{N1} {operation} {N2} = {result} - {evenOrOdd}");
            }
            else if (operation == '-')
            {
                result = N1 - N2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{N1} {operation} {N2} = {result} - {evenOrOdd}");
            }
            else if (operation == '*')
            {
                result = N1 * N2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{N1} {operation} {N2} = {result} - {evenOrOdd}");
            }


            else if (operation == '/')
            {
                if (N2 != 0)
                { Console.WriteLine($"{N1} / {N2} = {(N1 / N2):f2}");
                }
                 else if (N2 == 0)
                { Console.WriteLine($"Cannot divide {N1} by zero"); 
                }
            }
            else if (operation == '%')
            {   if (N2 != 0)
                {
                    Console.WriteLine($"{N1} % {N2} = {N1 % N2}");
                }
            else if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }

            
               

        }    
    }
}
