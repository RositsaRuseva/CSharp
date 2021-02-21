using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Models.Contracts;
using Vehicles.Common;

namespace Vehicles.Models
{
    public abstract class Vehicle : IDriveable, IRefuelable
    {
        private const string SUCC_DRIVED_MSG = "{0} travelled {1} km";
        public double FuelQuantity { get; private set; }
        public virtual double FuelConsumption { get; }

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public string Drive(double amount)
        {
            double fuelNeeded = amount * this.FuelConsumption;

            if (this.FuelQuantity < fuelNeeded)
            {
                throw new InvalidOperationException(String.Format
                    (ExceptionMessages.NOT_ENOUGH_FUEL, this.GetType().Name));
            }
            this.FuelQuantity -= fuelNeeded;
            return String.Format(SUCC_DRIVED_MSG, this.GetType().Name, amount);
        }

        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException
                    (ExceptionMessages.NEGATIVE_FUEL);
            }
            this.FuelQuantity += amount;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
