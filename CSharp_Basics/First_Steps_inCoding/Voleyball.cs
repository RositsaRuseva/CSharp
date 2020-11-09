using System;

namespace Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leapOrNormal = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int weekends = 48;
            double sofiaWeekends = ((weekends - h) * 3.0) / 4.0 ;
            double holidayGamesInSofia = (p * 2.0) / 3.0;
            double games = sofiaWeekends + holidayGamesInSofia + h;
            double totalWithDiscount = 0.0;
            
            if (leapOrNormal == "leap")
            {
                totalWithDiscount = games + (games * 0.15);
                Console.WriteLine(Math.Floor(totalWithDiscount));

            }
            else if (leapOrNormal == "normal")
            {
                Console.WriteLine(Math.Floor(games));
            }
        }
    }
}
