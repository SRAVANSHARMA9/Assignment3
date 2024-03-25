using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // Inherits from Vehicle, adding motorcycle-specific properties and displaying its details.
    public class Motorcycle : Vehicle
    {
        // Properties specific to motorcycles.
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }

        // Displays motorcycle details, extending base vehicle details.
        public override void DisplayDetails()
        {
            base.DisplayDetails(); // Show common vehicle details
            // Show motorcycle-specific details
            Console.WriteLine($"Engine Capacity: {EngineCapacity}cc, Fuel Type: {FuelType}, Has Fairing: {HasFairing}");
        }
    }
}
