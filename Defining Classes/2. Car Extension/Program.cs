using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
          
            Car car = new Car();

            car.Make = "BMW";
            car.Model = "118d";
            car.Year = 2012;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
            
        }
    }
}
