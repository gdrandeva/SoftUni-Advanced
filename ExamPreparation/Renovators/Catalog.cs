using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;

        public Catalog(string name, int neededRenocators, string Projects)
        {
            renovators = new List<Renovator>();
            Name = name;
            NeededRenovators = neededRenovators;
            Projects = projects;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int neededRenovators;

        public int NeededRenovators
        {
            get { return neededRenovators; }
            set { neededRenovators = value; }
        }

        private string projects;

        public string Projects
        {
            get { return projects; }
            set { projects = value; }
        }

        public int Count { get { return renovators.Count; }  }

        public string AddRenovators(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return $"Invalid renovator`s information.";
            }
            if (neededRenovators < renovators.Count)
            {
                return $"Renovators are no more needed";
            }
            if (renovator.Rate> 350)
            {
                return $"Invalid renovators rate";
            }
            renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog";

           
        }

        public bool RemoveRenovator(string name)
        {
            Renovator renovator = renovators.FirstOrDefault(x => x.Name==name);

            return renovators.Remove(renovator);
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            List<Renovator> leftRenovators = renovators.Where(r => r.Type != type).ToList();

            int removedCount = Count - leftRenovators.Count;

            renovators = leftRenovators;

            return removedCount;
        
        }

        public Renovator HireRenovator(string name)
        {
            Renovator renovator = renovators.FirstOrDefault(r => r.Name == name);

            if (renovator != null)
            {
                renovator.Hired = true;
            }

            return renovator;
        }

        public List<Renovator> PayRenovators(int days)
        {
            return renovators.Where(r => r.Days >= days).ToList();
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Renovators available for Project {projects}:");
            List<Renovator> unhiredRenovators = renovators.Where(r => r.Hired == false).ToList();

            foreach (var unh in unhiredRenovators)
            {
                result.AppendLine(unh.ToString());
            }

            return result.ToString().Trim();
        }



    }
}
