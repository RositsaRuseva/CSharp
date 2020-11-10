using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double resultOfInterval = 0;
            double second = 0;
            double third = 0;
            double fourth = 0;
            double fifth = 0;
            double sixth = 0;
            double invalid = 0;


            for (int i = 0; i < n; i++)
            {
                double result = double.Parse(Console.ReadLine());
                

                if (result>=0 && result <=9)
                {
                    second++;
                    resultOfInterval += result * 0.20;
                }
                else if(result>=10 && result<=19)
                {
                    third++;
                    resultOfInterval += result * 0.30;
                }
                else if(result >=20 && result <=29)
                {
                    fourth++;
                    resultOfInterval += result * 0.40;
                }
                else if(result >=30 && result <=39)
                {
                    fifth++;
                    resultOfInterval += 50;
                }
                else if(result >=40 && result <=50)
                {
                    sixth++;
                    resultOfInterval += 100;
                }
                else
                {
                    invalid++;
                    resultOfInterval = resultOfInterval / 2;
                }
            }

            Console.WriteLine($"{resultOfInterval:f2}");
            Console.WriteLine($"From 0 to 9: {0:f2}%", (second/n)*100);
            Console.WriteLine($"From 10 to 19: {0:f2}%", (third/n)*100);
            Console.WriteLine($"From 20 to 29: {0:f2}%",(fourth/n)*100);
            Console.WriteLine($"From 30 to 39: {0:f2}%",(fifth/n)*100);
            Console.WriteLine($"From 40 to 50: {0:f2}%",(sixt/n)*100);
            Console.WriteLine($"Invalid numbers: {0:f2}%",(invalid/n)*100);

        }
    }
}
