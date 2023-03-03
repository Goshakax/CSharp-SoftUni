using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKm, double tankCapacity) 
            : base(fuelQuantity, litersPerKm, tankCapacity)
        {
            LitersPerKm += 1.6;
        }

       

        public override void Refuel(double fuelAmount)
        {
            if (fuelAmount<=0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                
                
                if (fuelAmount + FuelQuantity <= Capacity)
                {
                    fuelAmount = 0.95 * fuelAmount;
                    FuelQuantity += fuelAmount;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
                }

            }

        }

        public override string ToString()
        {
            return $"Truck: {FuelQuantity:f2}";
        }
    }
}
