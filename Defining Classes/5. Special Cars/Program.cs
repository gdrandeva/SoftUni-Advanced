using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Tire[]> tires = new List<Tire[]>();

            while (input != "No more tires")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Tire[] singleTire = new Tire[] { };
                int index = 0;

                for (int i = 0; i < singleTire.Length; i++)
                {
                    int tireYear = int.Parse(command[index]);
                    index++;
                    double tirePressure = double.Parse(command[index]);
                    singleTire[i] = new Tire(tireYear, tirePressure);
                    index++;
                }
                tires.Add(singleTire);



                input = Console.ReadLine();
            }
            List<Engine[]> engines = new List<Engine[]>();
            while (input != "Engines done")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Engine[] engine = new Engine[] { };
                int index = 0;

                for (int i = 0; i < engine.Length; i++)
                {
                    int engineHorsePower = int.Parse(command[0]);
                    index++;
                    double engineCubicCap = double.Parse(command[1]);
                    engine[i] = new Engine(engineHorsePower, engineCubicCap);
                    index++;
                }
                engines.Add(engine);


                input = Console.ReadLine();
            }

            List<Car> cars = new List<Car>();

            while (input != "Show special")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Car[] car = new Car[] { };
                int index = 0;

                for (int i = 0; i < car.Length; i++)
                {

                    string carMake = command[0];
                    string carModel = command[1];
                    int carYear = int.Parse(command[2]);
                    double carFuelQuantity = double.Parse(command[3]);
                    double carFuelConsumption = double.Parse(command[4]);
                    int engineIndex = int.Parse(command[5]);
                    int tireIndex = int.Parse(command[6]);
                    car[i] = new Car(carMake, carModel, carYear, carFuelQuantity, carFuelConsumption,engineIndex,tireIndex);
);
                }



            }
        }
    }
}
