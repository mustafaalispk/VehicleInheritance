using static System.Console;
using VehicleInheritance.Domain;

namespace VehicleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] boatVehicleCargo = new Vehicle[30];

            boatVehicleCargo[0] = new Car(brand: "Tesla",
                model: "3",
                registrationNumber: "kbh252",
                carType: CarType.Sedan);

            boatVehicleCargo[1] = new Truck(brand: "Volvo",
                model: "F300",
                registrationNumber: "AAA222",
                fuelType: FuelType.Diesel,
                cargoHoldCapacity: 30                
                );

            foreach (Vehicle vehicle in boatVehicleCargo)
            {
                if (vehicle == null) continue;
                // ? operator, om den är null då kommer den inte anroppas Report()
                WriteLine(vehicle);
                //WriteLine(vehicle.ToString());
                //vehicle?.Report();
                //vehicle.Report();
            }
            
            ReadKey(true);
            

            }

        }
    }

