using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerArchitecture
{
    public class CPU
    {
        private string brand;
        private int cores;
        private double frequency;


        public CPU(string brand, int cores, double frequency)
        {
            this.Brand = brand;
            this.Cores = cores;
            this.Frequency = frequency;
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        

        public int Cores
        {
            get { return cores; }
            set { cores = value; }
        }

       

        public double Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }


        public override string ToString()
        {

            StringBuilder result = new StringBuilder();

            result.AppendLine($"{this.Brand} CPU: ");
            result.AppendLine($"Cores: {this.Cores}");
            result.AppendLine($"Frequency: {this.Frequency} GHz");

            return result.ToString().Trim();
        }



    }
}
