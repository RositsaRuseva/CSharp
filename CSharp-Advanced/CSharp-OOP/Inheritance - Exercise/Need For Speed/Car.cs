using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double DefautCarFuelConsumption = 3;
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DefautCarFuelConsumption;

        public override void Drive(double kilometers)
        {
            double fuelAfterDrive = Fuel - kilometers * FuelConsumption;
            if (fuelAfterDrive >= 0)
            {
                Fuel = fuelAfterDrive;
            }
        }
    }
}
