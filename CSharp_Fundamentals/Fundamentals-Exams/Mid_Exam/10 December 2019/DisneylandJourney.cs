using System;

namespace DisneyLandJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double saved = 0;
      

            for (int i = 1; i <= months; i++)
            {
                double bonus = saved * 0.25;

                if (i >= 2 && i % 2 != 0)
                {
                    saved -= saved * 0.16;
                    //saved += money * 0.25;
                }
                saved += money * 0.25;
                if (i % 4 == 0)
                {
                    saved += bonus;
                }
            }
            if (saved >= money)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {(saved - money):f2}lv. for souvenirs.");

            }
            else
            {
                Console.WriteLine($"Sorry. You need {(money - saved):f2}lv. more.");
            }
        }
    }
}
