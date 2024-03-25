using Assignment3;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Indian vehicles
        Car car = new Car
        {
            Model = "Swift",
            Manufacturer = "Maruti Suzuki",
            Year = 2021,
            RentalPrice = 1200m, // Assuming rental price in INR per day
            Seats = 5,
            EngineType = "1.2L VVT",
            Transmission = "Manual",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "Tata Ace",
            Manufacturer = "Tata Motors",
            Year = 2020,
            RentalPrice = 1500m, // Assuming rental price in INR per day
            Capacity = 0.75, // In tons
            TruckType = "Mini Truck",
            FourWheelDrive = false
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Royal Enfield Classic 350",
            Manufacturer = "Royal Enfield",
            Year = 2022,
            RentalPrice = 800m, // Assuming rental price in INR per day
            EngineCapacity = 346, // in cc
            FuelType = "Petrol",
            HasFairing = false
        };

        // Create a rental agency and add the vehicles
        RentalAgency rentalAgency = new RentalAgency();
        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        // Display details of each vehicle in the fleet
        Console.WriteLine("Vehicle Fleet Details:");
        rentalAgency.DisplayFleet();

        Console.WriteLine("Renting the Swift Car for 2 days and Enfield Classic Motorcycle for 3 days.\n");

        // Rent out the car and motorcycle, then display total revenue
        rentalAgency.RentVehicle(car, 2); // Rent car for 2 days
        rentalAgency.RentVehicle(motorcycle, 3); // Rent motorcycle for 3 days

        Console.WriteLine($"Total Revenue: {rentalAgency.TotalRevenue} Rupees");
    }
}
