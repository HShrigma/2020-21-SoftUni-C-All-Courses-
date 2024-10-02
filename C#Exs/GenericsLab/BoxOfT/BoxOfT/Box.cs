using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> data;
        public List<T> Data
        {
            get { return data; }
            set { data = new List<T>(); }
        }

        public Box()
        {
            Data = new List<T>();
        }

        /// <summary>
        /// Gets the count of the Box;
        /// </summary>
        public int Count => this.Data.Count;

        /// <summary>
        /// Adds an element to the Box
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            this.Data.Add(element);
        }
        /// <summary>
        /// Removes an element from the Box.
        /// </summary>
        /// <param name="element"> Element to remove</param>
        /// <returns></returns>
        public T Remove()
        {
            T element = this.Data[this.Data.Count - 1];

            this.Data.RemoveAt(this.Data.Count - 1);
            return element;
        }
    }
}
