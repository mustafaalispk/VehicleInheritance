using static System.Console;
namespace VehicleInheritance.Domain
{
    class Car : Vehicle
    {
        // Property kan inte lagra data, det är field som lagra data.
        // Property skapar upp själv en auto-implemented backing field i minnet 
        public CarType CarType { get; }

        private bool isTrunkOpen;
        public Car(string brand, string model, string registrationNumber, CarType carType)  
          :base (brand, model, registrationNumber, FuelType.Electrical)
            
        {
            
            CarType = carType;            
            
        }

        public void Opentruk()
        {

            isTrunkOpen = true;
        }
        public void CloseTrunk()
        {
            isTrunkOpen = false;
        }

        public override void Accelerate()
        {
            Velocity += 5;
        }

        public override void Break()
        {
            Velocity -= 5;
        }

        public override string ToString()
        {
            return ($"Car {Brand} {Model} {RegistrationNumber} {CarType}");
        }
    }

}
