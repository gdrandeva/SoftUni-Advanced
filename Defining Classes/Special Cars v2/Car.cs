﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        private Engine engine;

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        private Tire[] tires;

        public Tire[]  Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }




        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }

        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        //public void Drive(double distance)
        //{
        //    if (fuelQuantity - (distance * fuelConsumption) > 0)
        //    {
        //        fuelQuantity -= distance * fuelConsumption;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not enough fuel to perform this trip!");
        //        return;
        //    }
        //}

        //public string WhoAmI()
        //{
        //    return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.fuelQuantity:f2}";

        //}

    }
}
