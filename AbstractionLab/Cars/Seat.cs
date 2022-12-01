using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }
        public string Model { get; private set; }

        public string Color { get; private set; }

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
            sb.AppendLine($"{this.Color} Seat {this.Model}")
                .AppendLine("Engine start")
                .AppendLine("Breaaak!");

            return sb.ToString().Trim();
        }
    }
}
