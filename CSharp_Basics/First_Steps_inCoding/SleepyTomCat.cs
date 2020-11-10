using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOffInAYear = int.Parse(Console.ReadLine());


            int workingDays = 365 - daysOffInAYear;
            int playingDuringWorkingDays = workingDays * 63;
            int playingDuringFreeDays = daysOffInAYear * 127;
            int totalPlayingTime = playingDuringWorkingDays + playingDuringFreeDays;

            int time = 0;
            int hours = 0;
            int minutes = 0;

            if (totalPlayingTime <= 30000)
            { time = 30000 - totalPlayingTime;
                hours = time / 60;
                minutes = time % 60;
                Console.WriteLine($"Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }

            else
            { time = totalPlayingTime - 30000;
                hours = time / 60;
                minutes = time % 60;
                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            

        }
    }
}
