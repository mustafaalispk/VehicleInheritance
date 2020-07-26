using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInheritance.Domain
{
    abstract class Vehicle
    {        
        public string RegistrationNumber { get; }
        public string Brand { get;  }
        public string Model { get; }
        public FuelType FuelType { get;  }

        // I protected set, Ärvande klassar kan bara sätta värden.
        public ushort Velocity { get; protected set; }

        public Vehicle(string brand, string model, string registrationNumber, FuelType fuelType)
        {
            RegistrationNumber = registrationNumber;
            Brand = brand;
            Model = model;
            FuelType = fuelType;
        }
    }
}
