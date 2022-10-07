using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{


    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items;
        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                this.CheckIndex(index);
                return this.items[index];
            }
            set
            {
                this.CheckIndex(index);
                this.items[index] = value;
            }
        }

        public void Add(int item)
        {
            if (this.items.Length == this.Count)
            {
                this.Resize();
            }
            this.items[Count] = item;

            this.Count++;
        }
        public void AddRange(int[] array)
        {
            foreach (var item in array)
            {
                this.Add(item);
            }
        }

        public int RemoveAt(int index)
        {


            return 0;
        }

        public bool Contains(int item)
        {
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {

        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                int currentItem = this.items[i];
                action(currentItem);
            }
        }








        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];

            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;


        }
        private void Shrink()
        {


        }
        private void ShiftLeft()
        {

        }
        private void CheckIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

    }
}
