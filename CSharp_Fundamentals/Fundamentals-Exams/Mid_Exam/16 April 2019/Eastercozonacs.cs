using System;

namespace EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceFor1Floor = double.Parse(Console.ReadLine());

            double priceFor1packEggs = priceFor1Floor * 0.75;
            double priceFor1lMilk = priceFor1Floor * 1.25;
            //For one cozonac, price will need priceFor1lMilk / 4
            double priceFor250Milk = priceFor1lMilk / 4;

            double priceFor1Cozonac = priceFor1Floor + priceFor1packEggs + priceFor250Milk;
            //Console.WriteLine(priceFor1packEggs);
            //Console.WriteLine(priceFor1lMilk);
            //Console.WriteLine(priceFor250Milk);
            // Console.WriteLine();
            int coloredEggs = 0;
            int cozonacCount = 0;
            while (budget >= priceFor1Cozonac)
            {
                budget -= priceFor1Cozonac;
                cozonacCount++;
                coloredEggs += 3;
                if(cozonacCount % 3 == 0)
                {
                    coloredEggs -= cozonacCount - 2;
                }
            }
            Console.WriteLine($"You made {cozonacCount} cozonacs! Now you have {coloredEggs} eggs and {budget:f2}BGN left.");
        }
    }
}
