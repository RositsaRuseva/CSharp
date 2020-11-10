using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double taxiDayPrice = 0.70 + (0.79 * n);
            double taxiNightPrice = 0.70 + (0.90 * n);

            double busPrice = 0.09 * n;
            double trainPrice = 0.06 * n;

            if (n >= 20 && n < 100)
            {
                Console.WriteLine($"{busPrice:F2}");
            }

          
            else if (n >= 100)
            { Console.WriteLine($"{trainPrice:F2}"); 
            }

            else if (n < 20 && dayOrNight == "day")
            { Console.WriteLine($"{taxiDayPrice:F2}");
            }

            else if (n < 20 && dayOrNight == "night")
            { Console.WriteLine($"{taxiNightPrice:F2}");
            }



                




        }
    }
}
