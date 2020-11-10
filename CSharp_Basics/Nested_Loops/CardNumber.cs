using System;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());

            for (int x1 = begin; x1 <= finish; x1++)
            {
                for (int x2 = begin; x2 <= finish; x2++)
                {
                    for (int x3 = begin; x3 <= finish; x3++)
                    {
                        for (int x4 = begin; x4 < x1; x4++)
                        {
                            if (x1 > x4)
                            {
                                if (x1 % 2 == 0)
                                {
                                    if (x4 % 2 != 0)
                                    {
                                        if ((x1 - x4) % 2 != 0 && (x2 + x3) % 2 == 0)
                                        {
                                            Console.Write($"{x1}{x2}{x3}{x4} ");
                                        }
                                    }
                                }

                                else
                                {
                                    if (x4 % 2 == 0)
                                    {
                                        if (x1 % 2 != 0)
                                        {
                                            if ((x1 - x4) % 2 != 0 && (x2 + x3) % 2 == 0)
                                            {
                                                Console.Write($"{x1}{x2}{x3}{x4} ");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
