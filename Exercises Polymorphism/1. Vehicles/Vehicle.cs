

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, double fuelConsumpIncrement)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption+fuelConsumpIncrement;
        }
        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public string Drive(double distance)
        {
            double neededFuel = distance * this.FuelConsumption;
            if (neededFuel > this.FuelQuantity)
            {
                //Not enough fuel
                throw new InsufficientFuelException(string.Format(ExceptionMessages.InsufficientFuelExceptionMessage, this.GetType().Name));
            }
            this.FuelQuantity -= neededFuel;

            return $"{this.GetType().Name} travelled {distance} km";
        }
        //truck has different refuel logic (we will use run time polymorphism) -> we need to use a virtual method
        public virtual void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
