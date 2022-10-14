using System;
using System.Collections.Generic;

namespace RawData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carProperties = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(
                    carProperties[0],
                    int.Parse(carProperties[1]),
                    int.Parse(carProperties[2]),
                    int.Parse(carProperties[3]),
                    carProperties[4],
                    double.Parse(carProperties[5]),
                    int.Parse(carProperties[6]),
                    double.Parse(carProperties[7]),
                    int.Parse(carProperties[8]),
                    double.Parse(carProperties[9]),
                    int.Parse(carProperties[10]),
                    double.Parse(carProperties[11]),
                    int.Parse(carProperties[12]));

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {

            }
            else
            {

            }
        }
    }
}
