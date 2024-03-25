using System;
using System.Collections.Generic;

namespace Assignment3
{
    // Defines a RentalAgency class to manage a fleet of rental vehicles
    public class RentalAgency
    {
        // Private list to hold the collection of vehicles in the fleet
        private List<Vehicle> fleet = new List<Vehicle>();

        // Property to track the total revenue earned by the rental agency
        public decimal TotalRevenue { get; private set; }

        // Adds a vehicle to the fleet
        // Parameter 'vehicle' is the Vehicle object to be added
        public void AddVehicle(Vehicle vehicle)
        {
            fleet.Add(vehicle); // Add the specified vehicle to the fleet
        }

        // Removes a vehicle from the fleet
        // Parameter 'vehicle' is the Vehicle object to be removed

        public bool RemoveVehicle(Vehicle vehicle)
        {
            return fleet.Remove(vehicle); // Attempt to remove the specified vehicle from the fleet
        }

        // Rents a vehicle for a specified number of days, increasing total revenue
        // Parameter 'vehicle' is the Vehicle object being rented
        // Parameter 'days' is the number of days the vehicle is rented for
        public void RentVehicle(Vehicle vehicle, int days)
        {
            TotalRevenue += vehicle.RentalPrice * days; // Calculate revenue based on rental price and days rented, then add to total revenue
        }

        // Displays details of all vehicles in the fleet
        public void DisplayFleet()
        {
            // Iterate over each vehicle in the fleet
            foreach (var vehicle in fleet)
            {
                vehicle.DisplayDetails(); // Call the DisplayDetails method of each vehicle
                Console.WriteLine(); // Print a newline for better readability
            }
        }
    }
}
