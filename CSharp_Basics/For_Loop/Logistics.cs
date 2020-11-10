using System;

namespace Logistics2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCargo = int.Parse(Console.ReadLine());

            double priceMiniBus = 0;
            double priceTruck = 0;
            double priceTrain = 0;

            double sumCargoMiniBus = 0;
            double sumCargoTruck = 0;
            double sumCargoTrain = 0;
            double sumCargo = 0;

            for (int i = 1; i <= numberOfCargo; i++)
            {
                int tonnageOfCargo = int.Parse(Console.ReadLine());
                sumCargo += tonnageOfCargo;
                if (tonnageOfCargo <= 3)
                {
                    sumCargoMiniBus += tonnageOfCargo;
                    priceMiniBus += tonnageOfCargo * 200;
                }
                if(tonnageOfCargo >3 && tonnageOfCargo<=11)
                {
                    sumCargoTruck += tonnageOfCargo;
                    priceTruck += tonnageOfCargo * 175;
                }
                if(tonnageOfCargo >11)
                {
                    sumCargoTrain += tonnageOfCargo;
                    priceTrain += tonnageOfCargo * 120;
                }
            }

            double sumAvaragePrice = (priceMiniBus + priceTruck + priceTrain) / sumCargo;
            double percentMiniBus = sumCargoMiniBus/ sumCargo *100;
            double percentTruck = sumCargoTruck / sumCargo * 100;
            double percentTrain = sumCargoTrain / sumCargo * 100;

            Console.WriteLine($"{sumAvaragePrice:f2}");
            Console.WriteLine($"{percentMiniBus:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");
        }
    }
}
