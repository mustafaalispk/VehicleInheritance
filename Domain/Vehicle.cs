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

        //Alla får hämta den men bara ärvande klass får sätta värden på den.
        // I protected set, Ärvande klassar kan bara sätta värden.
        public ushort Velocity { get; protected set; }

        public Vehicle(string brand, string model, string registrationNumber, FuelType fuelType)
        {
            RegistrationNumber = registrationNumber;
            Brand = brand;
            Model = model;
            FuelType = fuelType;
        }
        // I abstract, alla måste kunna men accellera inte beetende på samma sätt.
        public abstract void Accelerate();
        public abstract void Break();
       
    }
}
