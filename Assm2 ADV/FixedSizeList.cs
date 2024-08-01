using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm2_ADV
{
    public class FixedSizeList<T>
    {
        private T[] items;
        private int count;
        private int capacity;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }

            this.capacity = capacity;
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= capacity)
            {
                throw new InvalidOperationException("The list is full. Cannot add more items.");
            }

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            return items[index];
        }

        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return capacity; }
        }
    }
}
