using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string model = input[0];
                Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Cargo cargo = new Cargo(int.Parse(input[3]), input[4]);
                Tires[] tire = new Tires[]
                {
                    new Tires(int.Parse(input[6]), double.Parse(input[5])),
                    new Tires(int.Parse(input[8]), double.Parse(input[7])),
                    new Tires(int.Parse(input[10]), double.Parse(input[9])),
                    new Tires(int.Parse(input[12]), double.Parse(input[11]))
                };
                Car car = new Car(model, cargo, engine, tire);
                carList.Add(car);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                carList.Where(x => x.Tire.Any(t => t.Pressure < 1))
                    .Where(x => x.Cargo.CargoType == "fragile")
                    .ToList().ForEach(x => Console.WriteLine(x.Model));
            }
            else if(command == "flamable")
            {
                carList.Where(x => x.Engine.EnginePower > 250)
                    .Where(x => x.Cargo.CargoType == "flamable")
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.Model));
            }
        }
    }
}
