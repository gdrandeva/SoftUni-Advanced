using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }
        public string Model { get; private set; }

        public string Color { get; private set; }

        public int Battery { get; private set; }

        public string Start()
        {
            return "Breaaak!";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries")
                .AppendLine("Engine start")
                .AppendLine("Breaaak!");

            return sb.ToString().Trim();
        }
    }
}
