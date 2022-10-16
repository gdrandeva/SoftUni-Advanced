using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethodSwapInt
{
    public class Box<T> 
    {
        public Box()
        {
            Items = new List<T>();
        }

        public List<T> Items { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}"); //item.GetType();
            }

            return sb.ToString().Trim();
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temp = Items[firstIndex];
            Items[firstIndex] = Items[secondIndex];
            Items[secondIndex] = temp;

            (Items[secondIndex], Items[firstIndex])= (Items[firstIndex], Items[secondIndex]);

        }


       

    }
}
