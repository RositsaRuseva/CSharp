using System;
using System.Linq;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var parking = new HashSet<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(", ");
                if (command[0] == "IN")
                {
                    parking.Add(command[1]);
                }
                else
                {
                    parking.Remove(command[1]);
                }
            }
            if (!parking.Any())
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in parking)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
