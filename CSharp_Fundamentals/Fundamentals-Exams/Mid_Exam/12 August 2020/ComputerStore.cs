using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            double price = 0;
            double taxes = 0;
            double totalPrice = 0;

            while (true)
            {
                command = Console.ReadLine();
                if(command == "special" || command == "regular")
                {
                    break;
                }
                double input = double.Parse(command);
                if (input < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    price += input;
                }

                //input = double.Parse(Console.ReadLine());
            }
            taxes = price * 0.20;
            totalPrice = price + taxes;
            if(command == "special")
            {
                totalPrice *= 0.90;
            }
            if (totalPrice <= 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {price:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
