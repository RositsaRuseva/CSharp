using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            int examStart = examHour * 60 + examMin; // start in minutes
            int arrival = arrivalHour * 60 + arrivalMin;
            int difference = arrival - examStart;
            int differenceHours = Math.Abs(difference / 60);
            int differenceMin = Math.Abs(difference) - differenceHours * 60;

            if (difference > 0)
            { Console.WriteLine("Late");
                if (difference >= 60)
                { Console.WriteLine($"{Math.Abs(differenceHours)}:{Math.Abs(differenceMin):00} hours after the start");
                }
                if (difference < 60)
                { Console.WriteLine($"{Math.Abs(differenceMin)} minutes after the start");
                }
            }
            else if (difference <= 0 && difference >= -30)
            {
                if (difference == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", Math.Abs(differenceMin));
                }
            }
            else if (difference < -30)
            {
                Console.WriteLine("Early");
                if (difference < - 30 && difference > - 60)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(differenceMin));
                }
                else
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", Math.Abs(differenceHours), Math.Abs(differenceMin));
                }
            }


        }
    }
}
