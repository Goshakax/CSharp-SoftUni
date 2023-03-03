using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace _02VehiclesExtension
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double litersPerKm, double tankCapacity) 
            : base(fuelQuantity, litersPerKm, tankCapacity)
        {
        }

        public override void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (fuelAmount + FuelQuantity <= Capacity)
                {
                    FuelQuantity += fuelAmount;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
                }
            }
        }

        public void DriveFull(double distance)
        {            
            FuelQuantity -= distance * (LitersPerKm+1.4);
        }
        public override string ToString()
        {
            return $"Bus: {FuelQuantity:f2}";
        }

    }
}
