using System;
using System.Runtime.CompilerServices;

namespace Harvest4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double total = 0.4 * (x * y) / 2.5;
            double left = 0.0;
            double perPerson = 0.0;
            double needed = 0.0;

            if (total >= z)
            {
                left = total - z;
                perPerson = left / n;

                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(total));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(left), Math.Ceiling(perPerson));
            
            }

            else
            {
                needed = z - total;

                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(needed));
            }
        }
    }
}
