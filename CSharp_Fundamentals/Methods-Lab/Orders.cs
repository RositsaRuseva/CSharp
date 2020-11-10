using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Order(order, n);


        }
        private static void Order(string order, int n)
        {
            double price = 0;
            switch (order)
            {
                case "coffee":
                    price = 1.50 * n;
                    break;
                case "water":
                    price = 1.00 * n;
                    break;
                case "coke":
                    price = 1.40 * n;
                    break;
                case "snacks":
                    price = 2.00 * n;
                    break;
            }
            //return price:f2;
            Console.WriteLine($"{price:f2}");
        }
    }
}
