using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        private const double DefautFuelConsumption = 1.25;
        public virtual double FuelConsumption => DefautFuelConsumption;
       
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;

        }
        public virtual void Drive(double kilometers)
        {
            double fuelAfterDrive = Fuel - kilometers * FuelConsumption;
            if (fuelAfterDrive >= 0)
            {
                Fuel = fuelAfterDrive;
            }
        }
        


    }
}
