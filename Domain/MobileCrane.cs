namespace VehicleInheritance.Domain
{
    class MobileCrane
    {
        // Property kan inte lagra data, det är field som lagra data.
        // Property skapar upp själv en auto-implemented backing field i minnet 
        public string RegistrationNumber { get; }
        public string Brand { get; }
        public string Model { get; }
        public FuelType FuelType { get; }
        public ushort Velocity { get; private set; }          
        public ushort LiftCapacity { get; }

        private bool isLifting;
        public MobileCrane(string brand, string model, string registrationNumber, FuelType fuelType, ushort liftCapacity)
        {
            RegistrationNumber = registrationNumber;
            Brand = brand;
            Model = model;
            FuelType = fuelType;
            LiftCapacity = liftCapacity;

        }

        public void Lift()
        {
            isLifting = true;
        }
        public void Drop()
        {
            isLifting = false;
        }

        public void Accelerate()
        {
            Velocity += 2;

        }
        public void Break()
        {
            Velocity -= 2;
        }

    }
}
