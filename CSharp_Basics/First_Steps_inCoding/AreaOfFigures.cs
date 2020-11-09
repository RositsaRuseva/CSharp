using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double result = 0;

            if (figure == "square")
            {
                double number = double.Parse(Console.ReadLine());
                result = number * number;
                Console.WriteLine($"{result:f3}");
            }
            else if (figure == "rectangle")
            {
                double number = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());
                result = number * number2;
                Console.WriteLine($"{result:f3}");
            }
            else if (figure == "circle")
            {
                double number = double.Parse(Console.ReadLine());
                result = Math.PI * (number * number);
                Console.WriteLine($"{result:f3}");
            }
            else if (figure == "triangle")
            {
                double number = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());
                result = 0.5 * number * number2;
                Console.WriteLine($"{result:f3}");
            }
            
        }
    }
}
