using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double litersPerKm)
        {
            FuelQuantity = fuelQuantity;
            LitersPerKm = litersPerKm;
        }

        public abstract double FuelQuantity { get;protected set; }
        public abstract double LitersPerKm { get;protected set; }

        public void Drive(double distance)
        {
            FuelQuantity -= distance * LitersPerKm;

        }
        public abstract void Refuel(double fuelAmount);
    }

}
