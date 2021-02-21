using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vehicles.Core.Contract;
using Vehicles.Models;
using Vehicles.Models.Contracts;
using Vehicles.Factories;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        private readonly VehicleFactory vehicleFactory;
        

        public Engine()
        {
            this.vehicleFactory = new VehicleFactory();
        }

        

        public void Run()
        {
            Vehicle car = this.ProcessVehicleInfo();
            Vehicle truck = this.ProcessVehicleInfo();

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArgs[0];
                string vehicleType = cmdArgs[1];
                //liters or kilometers
                double arg = double.Parse(cmdArgs[2]);
                try
                {
                    if (cmdType == "Drive")
                    {
                        if (vehicleType == "Car")
                        {
                            this.Drive(car, arg);
                        }
                        else if (vehicleType == "Truck")
                        {
                            this.Drive(truck, arg);
                        }
                    }
                    else if (cmdType == "Refuel")
                    {
                        if (vehicleType == "Car")
                        {
                            this.Refuel(car, arg);
                        }
                        else if (vehicleType == "Truck")
                        {
                            this.Refuel(truck, arg);
                        }
                    }
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
        private void Refuel(Vehicle vehicle, double amount)
        {
            vehicle.Refuel(amount);
        }
        private void Drive(Vehicle vehicle, double kilomoteres)
        {
            Console.WriteLine(vehicle.Drive(kilomoteres));
        }

        private Vehicle ProcessVehicleInfo()
        {
            string[] vehicleArgs =
                Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string vehicleType = vehicleArgs[0];
            double fuelQuantity = double.Parse(vehicleArgs[1]);
            double fuelConsumption = double.Parse(vehicleArgs[2]);

            Vehicle currVehicle = this.vehicleFactory.CreateVehicle
                (vehicleType, fuelQuantity, fuelConsumption);
            return currVehicle;
        }
    }
}
