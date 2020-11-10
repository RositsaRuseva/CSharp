using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int count1Lv = int.Parse(Console.ReadLine());
            int count2Lv = int.Parse(Console.ReadLine());
            int count5Lv = int.Parse(Console.ReadLine());

            int sum = int.Parse(Console.ReadLine());

            for (int x1 = 0; x1 <= count1Lv; x1++)
            {
                for (int x2 = 0; x2 <= count2Lv; x2++)
                {
                    for (int x3 = 0; x3 <= count5Lv; x3++)
                    {
                        if ( x1 * 1 + x2 * 2 + x3 * 5 == sum)
                        {
                            Console.WriteLine($"{x1} * 1 lv. + {x2} * 2 lv. + {x3} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
