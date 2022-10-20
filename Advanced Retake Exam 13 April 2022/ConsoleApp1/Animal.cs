using System.Text;

namespace Zoo
{
    public class Animal
    {

        public Animal(string spicies, string diet, double weight, double length)
        {
            this.Spicies = spicies;
            this.Diet = diet;
            this.Weight = weight;
            this.Length = length;
        }

        public string Spicies { get; set; }

        public string Diet { get; set; }

        public double Weight { get; set; }

        public double Length { get; set; }



        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"The {this.Spicies} is a {this.Diet} and weight {this.Weight} kg.");


            return result.ToString().Trim();
        }

    }
}




