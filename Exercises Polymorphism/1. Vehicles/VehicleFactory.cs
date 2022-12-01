
namespace Vehicles
{
   
    public class VehicleFactory : IVehicleFactory
    {
        //This should not be static
        public VehicleFactory()
        {

        }
        public IVehicle CreateVehicle(string type, double fuelQty, double fuelConsump)
        {
            IVehicle vehicle;
            if (type=="Car")
            {
                vehicle = new Car(fuelQty,fuelConsump);
            }
            else if (type=="Truck")
            {
                vehicle = new Truck(fuelQty,fuelConsump);
            }
            else
            {
                throw new InvalidVehicleType();
            }

            return vehicle;
        }
    }
}
