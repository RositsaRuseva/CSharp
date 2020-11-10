using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());

            int cake = cakeWidth * cakeLenght;
            bool finished = false;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                cake -= int.Parse(input);
                if (cake < 0)
                {
                    finished = true;
                    break;
                }

            }
            if (finished == true)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{cake} pieces are left.");
            }
        }
    }
}
