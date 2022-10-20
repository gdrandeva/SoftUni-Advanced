using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        private readonly List<Animal> animals;

        public Zoo(string name, int capacity)
        {
            this.animals = new List<Animal>();

            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Animal> Animals { get { return this.animals; }  }
        //private string name;

       
        public string AddAnimal(Animal animal)
        {
            
            if (string.IsNullOrWhiteSpace(animal.Spicies))
            {
                return "Invalid animal species.";
            }
            if (animal.Diet != "herbivore" && animal.Diet!="carnivore")
            {
                return "Invalid animal diet.";
            }
            if (this.Capacity <= animals.Count)
            {
                return "The zoo is full.";
            }

            this.animals.Add(animal);

            return $"Successfully added {animal.Spicies} to the zoo.";


        }

        public int RemoveAnimals(string species)
        {
            //List<Animal> removedAnimals = new List<Animal>();

            //foreach (var animal in animals)
            //{
            //    if (animal.Spicies == species)
            //    {
            //        removedAnimals.Add(animal);
            //    }
            //}

            //// animals = removedAnimals;

            //return removedAnimals.Count;
             return animals.RemoveAll(a => a.Spicies == species);
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animalsByDiet = new List<Animal>();

            foreach (var animal in animals)
            {
                if (animal.Diet == diet)
                {
                    animalsByDiet.Add(animal);
                }
            }
            return animalsByDiet;

            // return animals.FindAll(a => a.Diet == diet);
        }

        public Animal GetAnimalByWeight(double weight)
        {
            return this.animals.Find(a => a.Weight == weight);

            

        
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = this.animals.Where(a => a.Length >= minimumLength && a.Length <= maximumLength).Count();

            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        
        }

    }
}
