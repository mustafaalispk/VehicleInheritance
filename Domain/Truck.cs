namespace VehicleInheritance.Domain
{
    class Truck : Vehicle
    {
        // Property kan inte lagra data, det är field som lagra data.
        // Property skapar upp själv en auto-implemented backing field i minnet 
      
        public string[] cargoHold;

        public byte nextAvailablePosition;
     
        public Truck(string brand, string model, string registrationNumber, FuelType fuelType, byte cargoHoldCapacity)
            :base (brand, model,registrationNumber,fuelType)
        {            
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
