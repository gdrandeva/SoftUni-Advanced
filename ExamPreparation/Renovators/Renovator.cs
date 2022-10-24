using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        private string name;
        private string type;
        private double rate;
        private int days;
        private bool hired;

        public Renovator(string name, string type, double rate, int days)
        {
            Name = name;
            Type = type;
            Rate = rate;
            Days = days;
        }

        public string Name { get { return name; } set { this.name = value; } }
        public string Type { get { return type; } set { this.type = value; } }
        public double Rate { get { return rate; } set { this.rate = value; } }
        public int Days { get { return days; } set { this.days = value; } }
        public bool Hired { get { return hired; } set { this.hired = value; } }



        public override string ToString()
        {

            StringBuilder result = new StringBuilder();
            result.AppendLine($"-Renovator: {name}");
            result.AppendLine($"--Specialty: {type}");
            result.AppendLine($"--Rate per day: {rate} BGN");

            return result.ToString().Trim();

        }
    }
}
