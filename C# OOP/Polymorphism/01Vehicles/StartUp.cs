using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using Vehicles;

string[] carTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Vehicle car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]));

string[] truckTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Vehicle truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]));
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string cmd = tokens[0];
    string vehicleType = tokens[1];
    double distanceOrFuel = double.Parse(tokens[2]);

    if (vehicleType == "Car")
    {
        if (cmd == "Drive")
        {
            if (distanceOrFuel*car.LitersPerKm <= car.FuelQuantity)
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
            if (distanceOrFuel*truck.LitersPerKm <= truck.FuelQuantity)
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
}


Console.WriteLine(car.ToString());
Console.WriteLine(truck.ToString());
