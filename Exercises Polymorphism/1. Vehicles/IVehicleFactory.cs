
namespace Vehicles
{
   public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string type, double fuelQty, double fuelConsump);
    }
}
