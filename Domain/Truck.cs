﻿namespace VehicleInheritance.Domain
{
    class Truck
    {
        // Property kan inte lagra data, det är field som lagra data.
        // Property skapar upp själv en auto-implemented backing field i minnet 
        public string RegistrationNumber { get; }
        public string Brand { get; }
        public string Model { get; }
        public FuelType FuelType { get; }       
        public ushort Velocity { get; private set; }

        public string[] cargoHold;

        public byte nextAvailablePosition;
     
        public Truck(string brand, string model, string registrationNumber, FuelType fuelType, byte cargoHoldCapacity)
        {
            RegistrationNumber = registrationNumber;
            Brand = brand;
            Model = model;
            FuelType = fuelType;
            cargoHold = new string[cargoHoldCapacity];

        }
            
        public void Accelerate()
        {
            Velocity += 2;

        }
        public void Break()
        {
            Velocity -= 2;
        }

        public void Load(string cargo)
        {
            cargoHold[nextAvailablePosition++] = cargo;
        }

        public string Unload()
        {
            return cargoHold[nextAvailablePosition--];
            
        }
    }
}
