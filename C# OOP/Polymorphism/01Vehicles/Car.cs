using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double litersPerKm) 
            : base(fuelQuantity, litersPerKm)
        {
            LitersPerKm += 0.9;
        }

        public override double FuelQuantity { get ; protected set ; }
        public override double LitersPerKm { get; protected set; }


        public override void Refuel(double fuelAmount)
        {
            FuelQuantity+=fuelAmount;
        }

        public override string ToString()
        {
            return $"Car: {FuelQuantity:f2}";
        }
    }

}
