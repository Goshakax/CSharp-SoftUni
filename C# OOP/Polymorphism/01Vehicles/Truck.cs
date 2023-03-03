using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKm) 
            : base(fuelQuantity, litersPerKm)
        {
            LitersPerKm += 1.6;
        }

        public override double FuelQuantity { get ;protected set ; }
        public override double LitersPerKm { get; protected set ; }



        public override void Refuel(double fuelAmount)
        {
            fuelAmount = 0.95 * fuelAmount;
            FuelQuantity += fuelAmount;    
        }

        public override string ToString()
        {
            return $"Truck: {FuelQuantity:f2}";
        }
    }
}
