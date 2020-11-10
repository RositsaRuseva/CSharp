using System;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountADay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int amountFor30Days = int.Parse(Console.ReadLine());

            double sumAmount = 0;
            for (int i = 1; i <= 30; i++)
            {
                double totalADay = amountADay * workers;
                if (i % 3 == 0)
                {
                    sumAmount += Math.Floor(0.75 * totalADay);
                    
                }
                else
                {
                    sumAmount += totalADay;
                }

            }
            
            if (sumAmount > amountFor30Days)
            {
                double diff = sumAmount - amountFor30Days;
                double percent = diff / amountFor30Days * 100;
                Console.WriteLine($"You have produced {sumAmount} biscuits for the past month.");
                Console.WriteLine($"You produce {percent:f2} percent more biscuits.");
            }
            else if (amountFor30Days > sumAmount)
            {
                double diff = amountFor30Days - sumAmount;
                double percent = diff / amountFor30Days * 100;
                Console.WriteLine($"You have produced {sumAmount} biscuits for the past month.");
                Console.WriteLine($"You produce {percent:f2} percent less biscuits.");
            }
        }
    }
}
