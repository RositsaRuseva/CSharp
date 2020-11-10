using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int countCash = 0;
            int countCard = 0;
            int counter = 0;

            double sumCash = 0;
            double sumCard = 0;
            double totalSum = 0;

            bool hasEnoughMoney = false;

            
            while (command != "End") 
            {

                double input = int.Parse(command);

                if (counter % 2 == 0)
                {
                    if (input > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        sumCash += input;
                        countCash++;
                    }
                }
                else

                {
                    if (input < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        sumCard += input;
                        countCard++;
                    }

                }


                totalSum = sumCard + sumCash;
                if (totalSum >= goal)
                {
                    hasEnoughMoney = true;
                    break;
                }
                command = Console.ReadLine();
                counter++;

            }
            if (hasEnoughMoney)
            {
                Console.WriteLine($"Average CS: {sumCash / countCash:f2}");
                Console.WriteLine($"Average CC: {sumCard / countCard:f2}");
            }
            else
            {
                Console.WriteLine($"Failed to collect required money for charity.");
            }
        }
    }
}