namespace VehicleInheritance.Domain
{
    class Car : Vehicle
    {
        // Property kan inte lagra data, det är field som lagra data.
        // Property skapar upp själv en auto-implemented backing field i minnet 
        public CarType CarType { get; }

        private bool isTrunkOpen;
        public Car(string brand, string model, string registrationNumber, FuelType fuelType, CarType carType)  
          :base (brand, model, registrationNumber, fuelType)
            
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

        public void Accelerate()
        {
            Velocity += 5;

        }
        public void Break()
        {
            Velocity -= 5;
        }
    }

}
