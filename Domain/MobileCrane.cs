namespace VehicleInheritance.Domain
{
    class MobileCrane : Vehicle
    {
        // Property kan inte lagra data, det är field som lagra data.
        // Property skapar upp själv en auto-implemented backing field i minnet 
                 
        public ushort LiftCapacity { get; }

        private bool isLifting;
        public MobileCrane(string brand, string model, string registrationNumber, FuelType fuelType, ushort liftCapacity)
            :base (brand, model, registrationNumber,fuelType)
        {
           
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
            Velocity += 1;

        }
        public void Break()
        {
            Velocity -= 1;
        }

    }
}
