using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            int battles = 0;
            string command = Console.ReadLine();
            while (command != "End of battle")
            {
                
                int inputEnergy = int.Parse(command);
                if(initialEnergy < inputEnergy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battles} won battles and {initialEnergy} energy");
                    return;
                }

                initialEnergy -= inputEnergy;
                battles++;

                if(battles % 3 == 0)
                {
                    initialEnergy += battles;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {battles}. Energy left: {initialEnergy}");
            //Console.WriteLine($"Energy left: {initialEnergy}");
        }
    }
}
