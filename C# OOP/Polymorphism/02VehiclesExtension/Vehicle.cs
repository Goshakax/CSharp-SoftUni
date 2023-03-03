using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double litersPerKm;
        private double fuelQuantity;
        public Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity)
        {
            Capacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            LitersPerKm = litersPerKm;
            
        }

        public double Capacity { get; protected set; }
        public  double FuelQuantity
        {
            get 
            {
                return fuelQuantity;
            }
            protected set
            {
                if (value>Capacity)
                {
                    fuelQuantity = 0;
                    throw new ArgumentNullException($"Cannot fit {value} fuel in the tank");
                }

                fuelQuantity = value;
            }
        }


        public double LitersPerKm
        {
            get
            {
                return litersPerKm;
            }
            protected set
            {
                litersPerKm = value;
            }
        }

        public void Drive(double distance)
        {
            FuelQuantity -= distance * LitersPerKm;

        }
        public abstract void Refuel(double fuelAmount);
    }

}
