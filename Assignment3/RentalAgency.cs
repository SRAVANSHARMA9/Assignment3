using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class RentalAgency
    {
        private List<Vehicle> fleet = new List<Vehicle>();
        public decimal TotalRevenue { get; private set; }

        public void AddVehicle(Vehicle vehicle)
        {
            fleet.Add(vehicle);
        }

        public bool RemoveVehicle(Vehicle vehicle)
        {
            return fleet.Remove(vehicle);
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            TotalRevenue += vehicle.RentalPrice * days;
        }

        // Method to display details of all vehicles in the fleet
        public void DisplayFleet()
        {
            foreach (var vehicle in fleet)
            {
                vehicle.DisplayDetails();
                Console.WriteLine();
            }
        }
    }

}
