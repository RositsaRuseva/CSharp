using System;

namespace VacationWhileLoop1
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double startingMoney = double.Parse(Console.ReadLine());

            int spend = 0;
            int days = 0;

            while (startingMoney< neededMoney && spend <5)
            {
                string action = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());
                days++;

                if (action == "spend")
                {
                    spend++;
                    startingMoney -= currentMoney;
                    
                    if(startingMoney <0)
                    {
                        startingMoney = 0;
                    }
                }
                if(action =="save")
                {
                    spend = 0;
                    startingMoney += currentMoney;
                }
            }
            if (spend == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            if (startingMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
