using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            
            double priceStudio = 0.0;
            double priceAp = 0.0;

            
                if (month == "May" || month == "October")
                {
                priceStudio = 50.00 * nights;
                priceAp = 65.00 * nights;
                   if (nights >7 && nights < 14)
                   {
                    priceStudio = priceStudio - (priceStudio * 0.05);
                   }
                  else if (nights > 14)
                  { priceStudio = priceStudio - (priceStudio * 0.30);
                    priceAp = priceAp - (priceAp * 0.10);
                  }
                   
                   
                }
                else if (month == "June" || month == "September")
                {
                    priceStudio = 75.20 * nights;
                    priceAp = 68.70 * nights;

                if (nights > 14)
                  {
                    priceStudio = priceStudio - (priceStudio * 0.20);
                    priceAp = priceAp - (priceAp * 0.10);
                  }
                   

                }
                else if (month == "July" || month == "August")
                {
                   priceStudio = 76.00 * nights;
                   priceAp = 77.00 * nights;
                  if (nights > 14)
                   { priceAp = priceAp - (priceAp * 0.10);
                   }
                   
                }

            Console.WriteLine($"Apartment: {priceAp:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
            
            
                
                
        }

            
    }
 }

