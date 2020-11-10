using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            double capcity = double.Parse(Console.ReadLine());
            int numberOfFans = int.Parse(Console.ReadLine());

            double fansA = 0;
            double fansB = 0;
            double fansV = 0;
            double fansG = 0;

            

            double percentA = 0;
            double percentB = 0;
            double percentV = 0;
            double percentG = 0;

            double totalPercent = 0;

            for (int i = 1; i <= numberOfFans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    fansA++;                   
                }
                else if (sector == "B")
                {
                    fansB++;
                }
                else if (sector == "V")
                {
                    fansV++;
                }
                else if (sector == "G")
                {
                    fansG++;

                }


            }
            percentA = (fansA/numberOfFans) *100;
            percentB = (fansB / numberOfFans) * 100;
            percentV = (fansV / numberOfFans) * 100;
            percentG = (fansG / numberOfFans) * 100;

           totalPercent = (numberOfFans/capcity) *100;

            Console.WriteLine($"{percentA:f2}%");
            Console.WriteLine($"{percentB:f2}%");
            Console.WriteLine($"{percentV:f2}%");
            Console.WriteLine($"{percentG:f2}%");
            Console.WriteLine($"{totalPercent:f2}%");


        }
    }
}
