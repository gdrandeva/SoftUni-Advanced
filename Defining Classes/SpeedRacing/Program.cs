using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        
        
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, Car> carsList = new Dictionary<string, Car>();
            
            for (int i = 0; i < numberOfCars; i++)
            {
                Car car = new Car();
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
               
                car.Model = input[0];
                car.FuelAmount = double.Parse(input[1]);
                car.FuelConsumptionPerKilometer = double.Parse(input[2]);

                carsList.Add(car.Model, car);
            }

                while (true)
                {
                    string command = Console.ReadLine();
                    if (command=="End")
                    {
                        break;
                    }
                    string[] cmdAsArr = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                    string carModel = cmdAsArr[1];
                    double amountOfKm = double.Parse(cmdAsArr[2]);

                Car car = carsList[carModel];
                car.Drive(amountOfKm);


                   
                }
                foreach (var item in carsList.Values)
                {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");

                }
            
        }
    }
}
