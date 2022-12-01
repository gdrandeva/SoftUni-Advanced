﻿
namespace Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine : IEngine
    {
        private readonly IReader reader;

        private readonly IWriter writer;

        private readonly IVehicleFactory vehicleFactory;

        private readonly ICollection<IVehicle> vehicles;
        //private IVehicle car;

        //private IVehicle truck;

        private Engine()
        {
            this.vehicles = new HashSet<IVehicle>();
        }

        public Engine(IReader reader, IWriter writer, IVehicleFactory vehicleFactory)
            : this()
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;
        }
        public void Run()
        {
            this.vehicles.Add(this.BuildVehicleUsingFactory());
            this.vehicles.Add(this.BuildVehicleUsingFactory());

            int n = int.Parse(this.reader.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    this.ProcessCommand();
                }
                catch (InsufficientFuelException ife)
                {
                    this.writer.WriteLine(ife.Message);


                }
                catch (InvalidVehicleType ivt)
                {
                    this.writer.WriteLine(ivt.Message);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            this.PrintAllVehicles();
        }

        private IVehicle BuildVehicleUsingFactory()
        {
            string[] vehicleArgs = this.reader.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string vehicleType = vehicleArgs[0];
            double vehicleFuelQuantity = double.Parse(vehicleArgs[1]);
            double vehicleFuelConsumption = double.Parse(vehicleArgs[2]);

            IVehicle vehicle = this.vehicleFactory.CreateVehicle(vehicleType,vehicleFuelQuantity,vehicleFuelConsumption);

            return vehicle;
        }

        private void ProcessCommand()
        {

            string[] cmdArgs = this.reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string cmdType = cmdArgs[0];
            string vehicleType = cmdArgs[1];
            double arg = double.Parse(cmdArgs[2]);

            IVehicle vehicleToProcess = this.vehicles.FirstOrDefault(v => v.GetType().Name==vehicleType);
            if (vehicleToProcess == null)
            {
                throw new InvalidVehicleType();
            }
            if (cmdType == "Drive")
            {
                this.writer.WriteLine(vehicleToProcess.Drive(arg));
            }
            else if (cmdType == "Refuel")
            {
                vehicleToProcess.Refuel(arg);
            }
        }

        private void PrintAllVehicles()
        {
            foreach (IVehicle vehicle in this.vehicles)
            {
                this.writer.WriteLine(vehicle.ToString());
            }

        }
    }
}
