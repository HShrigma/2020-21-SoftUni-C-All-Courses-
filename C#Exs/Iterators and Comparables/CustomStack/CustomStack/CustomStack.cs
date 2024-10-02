using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class CustomStack<T>: IEnumerable<T>
    {
        private List<T> list;

        public CustomStack()
        {
            list = new List<T>();
        }

        public void Push(params T[] elements)
        {
            foreach (var element in elements)
            {
                list.Add(element);
            }
        }

        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("No elements");
            }
            else
            {
                T temp = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return temp;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
