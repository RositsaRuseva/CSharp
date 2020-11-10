using System;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsInFirstSector = int.Parse(Console.ReadLine());
            int seatsInOddRow = int.Parse(Console.ReadLine());

            int factor = 0;
            int counter = 0;

            for (char sector = 'A'; sector <= lastSector; sector ++, rowsInFirstSector++)
            {
                for (int rows = 1; rows <= rowsInFirstSector; rows++)
                {
                    
                    factor = (rows % 2 == 0) ? 2 : 0;

                    for (char seats = 'a'; seats < 'a' + seatsInOddRow + factor; seats++)
                    {
                        Console.WriteLine($"{sector}{rows}{seats}");
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
