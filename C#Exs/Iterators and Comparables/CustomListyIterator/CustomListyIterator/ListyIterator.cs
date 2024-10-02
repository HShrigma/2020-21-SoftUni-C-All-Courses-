using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomListyIterator
{
    public class ListyIterator<T>: IEnumerable<T>
    {
        private List<T> list;
        private int currentIndex;

        public ListyIterator(params T[] data)
        {
            this.list = new List<T>(data);
            this.currentIndex = 0;
        }

        public List<T> List {get{ return list; } set { list = value; } }

        public bool HasNext => currentIndex < list.Count - 1;

        public bool Move()
        {
            bool canMove = HasNext;

            if (canMove)
            {
                currentIndex++;
            }

            return canMove;
        }
        public void PrintAll()
        {
            Console.WriteLine(string.Join(' ', list));
        }
        public void Print()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine($"{list[currentIndex]}");
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
