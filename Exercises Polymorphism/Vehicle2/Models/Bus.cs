

namespace Vehicle2.Models
{
    using Vehicles.Models;

    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double fuelConsumptionIncrement)
            : base(fuelQuantity, fuelConsumption, fuelConsumptionIncrement)
        {
        }
    }
}
