using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double litersPerKm, double tankCapacity) 
            : base(fuelQuantity, litersPerKm, tankCapacity)
        {
            LitersPerKm += 0.9;
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

        public override string ToString()
        {
            return $"Car: {FuelQuantity:f2}";
        }
    }

}
