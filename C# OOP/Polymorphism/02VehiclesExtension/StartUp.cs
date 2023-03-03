using _02VehiclesExtension;
using Vehicles;

string[] carTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Vehicle car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]), double.Parse(carTokens[3]));

string[] truckTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Vehicle truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]), double.Parse(truckTokens[3]));

string[] busTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Vehicle bus = new Bus(double.Parse(busTokens[1]), double.Parse(busTokens[2]), double.Parse(busTokens[3]));

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{

    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string cmd = tokens[0];
    string vehicleType = tokens[1];
    double distanceOrFuel = double.Parse(tokens[2]);

    try
    {
        if (vehicleType == "Car")
        {
            if (cmd == "Drive")
            {
                if (distanceOrFuel * car.LitersPerKm <= car.FuelQuantity)
                {
                    car.Drive(distanceOrFuel);
                    Console.WriteLine($"Car travelled {distanceOrFuel} km");
                }
                else
                {
                    Console.WriteLine("Car needs refueling");
                }

            }
            else if (cmd == "Refuel")
            {
                car.Refuel(distanceOrFuel);
            }
        }
        else if (vehicleType == "Truck")
        {
            if (cmd == "Drive")
            {
                if (distanceOrFuel * truck.LitersPerKm <= truck.FuelQuantity)
                {
                    truck.Drive(distanceOrFuel);
                    Console.WriteLine($"Truck travelled {distanceOrFuel} km");
                }
                else
                {

                    Console.WriteLine("Truck needs refueling");
                }
            }
            else if (cmd == "Refuel")
            {
                truck.Refuel(distanceOrFuel);
            }
        }
        else if (vehicleType == "Bus")
        {
            if (cmd == "Drive")
            {
                if (distanceOrFuel * (bus.LitersPerKm + 1.4) <= bus.FuelQuantity)
                {
                    if (bus is Bus busAsBus)
                    {
                        busAsBus.DriveFull(distanceOrFuel);
                    }
                    Console.WriteLine($"Bus travelled {distanceOrFuel} km");
                }
                else
                {
                    Console.WriteLine("Bus needs refueling");
                }
            }
            else if (cmd == "DriveEmpty")
            {
                if (distanceOrFuel * bus.LitersPerKm <= bus.FuelQuantity)
                {
                    bus.Drive(distanceOrFuel);
                    Console.WriteLine($"Bus travelled {distanceOrFuel} km");
                }
                else
                {
                    Console.WriteLine("Bus needs refueling");
                }
            }
            else if (cmd == "Refuel")
            {
                bus.Refuel(distanceOrFuel);
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        throw;
    }


}

Console.WriteLine(car.ToString());
Console.WriteLine(truck.ToString());
Console.WriteLine(bus.ToString());
