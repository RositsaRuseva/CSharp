using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Models;
using Vehicles.Common;

namespace Vehicles.Factories
{
    public class VehicleFactory
    {
        public VehicleFactory()
        {

        }
        public Vehicle CreateVehicle(string vehicleType, double fuelQuanity,
            double fuelConsumption)
        {
            Vehicle vehicle;
            if (vehicleType == "Car")
            {
                vehicle = new Car(fuelQuanity,fuelConsumption);
            }
            else if (vehicleType == "Truck")
            {
                vehicle = new Truck(fuelQuanity, fuelConsumption);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.INVALID_VEHICLE_TYPE);
            }
            return vehicle;
        }
    }
}
