using System;

namespace CleverLillyLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryMachine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int toysCount = 0;
            double savedMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += i * 5;
                    savedMoney--;
                }
                else
                {
                    toysCount++;
                }
            }
            savedMoney += toysCount * toyPrice;

            if (savedMoney >= laundryMachine)
            {
                double diff = savedMoney - laundryMachine;
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                double diff = laundryMachine - savedMoney;
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
