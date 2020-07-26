namespace VehicleInheritance.Domain
{
    class Car
    {
        // Property kan inte lagra data, det är field som lagra data.
        // Property skapar upp själv en auto-implemented backing field i minnet 
        public string RegistrationNumber { get; }
        public string Brand { get; }
        public string Model { get; }
        public FuelType FuelType { get; }
        public CarType CarType { get; }
        public ushort Velocity { get; private set; }

        private bool isTrunkOpen;
        public Car(string brand, string model, string registrationNumber, FuelType fuelType, CarType carType)
        {
            RegistrationNumber = registrationNumber;
            Brand = brand;
            Model = model;
            FuelType = fuelType;
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
