using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Need_for_Speed
{
   public class Vehicle
    {
        private int horsePower;
        private double fuel;
        private const double DEFAULT_FUEL_CONSUMPTION = 1.25;
        private  double fuelConsumption;
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public virtual double FuelConsumption { get; set; }


        public virtual void Drive(double kilometers)
        {
            this.fuel -= DEFAULT_FUEL_CONSUMPTION * kilometers;

        }
    }
}
