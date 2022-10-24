using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        private List<CPU> multiprocessor;
        private string model;
        private int capacity;

        public Computer(string model, int capacity)
        {
            multiprocessor = new List<CPU>();
            this.Model = model;
            this.Capacity = capacity;
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        

        public List<CPU> Multiprocessor
        {
            get { return multiprocessor; }
            set { multiprocessor = value; }
        }

        public int Count { get { return this.Multiprocessor.Count; } }


        public List<CPU> Add(CPU cpu)
        {
            if (multiprocessor.Count<=Capacity)
            {
                if (!multiprocessor.Contains(cpu))
                {
                    multiprocessor.Add(cpu);
                    return multiprocessor;
                }
            }
           
            return null;
            
        
        }

        public bool Remove(string brand)
        {
            if (this.Multiprocessor.Any(b=>b.Brand==brand))
            {
                this.Multiprocessor.Remove(this.Multiprocessor.FirstOrDefault(b => b.Brand == brand));
                return true;

            }
            return false;
        
        }

        public CPU MostPowerful()
        {
            CPU mostPowerful = this.Multiprocessor.OrderByDescending(p => p.Frequency).FirstOrDefault();

            return mostPowerful;
        
        
        }

        public CPU GetCPU(string brand)
        {
            foreach (var item in multiprocessor)
            {
                if (item.Brand == brand)
                {
                    return item;
                }
                
            }
            return null;

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CPUs in the Computer {model}:");
            foreach (var item in multiprocessor)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
