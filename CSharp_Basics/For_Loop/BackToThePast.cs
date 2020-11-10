using System;

namespace BackToThePast1
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int age = 18;
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    money -= 12000;
                }
                else
                {
                    money = money - (12000 + age * 50);
                }
                age++;
            }
            if (money >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money);
            }
            else if (money < 0)
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(money));
            }
        }
    }
}
