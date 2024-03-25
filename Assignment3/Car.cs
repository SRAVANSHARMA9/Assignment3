using System;

namespace Assignment3
{
    // Represents a Car, inheriting common properties from Vehicle and adding car-specific properties.
    public class Car : Vehicle
    {
        // Number of seats in the car.
        public int Seats { get; set; }

        // Type of engine, e.g., V6, V8, Electric.
        public string EngineType { get; set; }

        // Type of transmission, e.g., Manual, Automatic.
        public string Transmission { get; set; }

        // Indicates whether the car is a convertible.
        public bool Convertible { get; set; }

        // Displays car details, enhancing the base Vehicle display with car-specific properties.
        public override void DisplayDetails()
        {
            base.DisplayDetails(); // Display common vehicle details
            // Display car-specific details
            Console.WriteLine($"Seats: {Seats}, Engine Type: {EngineType}, Transmission: {Transmission}, Convertible: {Convertible}");
        }
    }
}
