using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C__Advanced_2.FixedSizeList
{
    internal class FixedSizeList<T>
    {
        private T[] items;
        private int count;


        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return items.Length; }
        }



        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException("capacity must be greater than zero .");
            }
            this.items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= items.Length)
            {
                throw new InvalidOperationException("List is full . can't add more items");
            }
            items[count++] = item;
        }
        public T Get(int index)
        {
            if(index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException("invalid index");
            }
            return items[index];
        }
    }

}
