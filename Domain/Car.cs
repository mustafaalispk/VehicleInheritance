using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInheritance.Domain
{
    class Car
    {
      // Property kan inte lagra data, det är field som lagra data.
      // Property skapar upp själv en auto-implemented backing field i minnet 
     public string RegistrationNumber { get; }
     public string Brand { get; }
     public string Model { get; }
     
     public Car(string registrationNumber, string brand, string model)
     {
       RegistrationNumber = registrationNumber;
       Brand = brand;
       Model = model;
     }
    }
}
