using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        /// <summary>
        /// The number of elements in the doubly linked list.
        /// (read only after it is initialized)
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// First element
        /// </summary>
        public ListNode Head { get; set; }
        /// <summary>
        /// Last element
        /// </summary>
        public ListNode Tail { get; set; }

        public DoublyLinkedList()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }
        /// <summary>
        /// Creates a doubly linked list of 1 element
        /// </summary>
        /// <param name="value"> value of the element </param>
        public DoublyLinkedList(int value)
            : this()
        {
            Head = Tail = new ListNode(value) { Previous = null, Next = null };
            Count++;

        }
        /// <summary>
        /// Creates a collection of elements.
        /// </summary>
        /// <param name="list">elements to add to collection.</param>
        public DoublyLinkedList(IEnumerable<int> list)
            : this(list.First())
        {
            bool isFirst = true;

            foreach (var item in list)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    ListNode newNode = new ListNode(item);
                    newNode.Previous = Tail;
                    newNode.Next = null;

                    Tail.Next = newNode;
                    Tail = newNode;
                    Count++;
                }

            }
        }
        /// <summary>
        /// Adds an element at the start of the collection
        /// </summary>
        /// <param name="element">element to be added</param>
        public void AddFirst(int element)
        {
            ListNode newNode = new ListNode(element);

            if (Count == 0)
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }

            Count++;
        }
        /// <summary>
        /// Adds an element at the end of the collection
        /// </summary>
        /// <param name="element">element to be added</param>
        public void AddLast(int element)
        {
            ListNode newNode = new ListNode(element);

            if (Count == 0)
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.Previous = Tail;
                Tail.Next = newNode;
                Tail = newNode;
            }

            Count++;
        }
        /// <summary>
        /// Removes the element at the start of the collection
        /// </summary>
        /// <returns></returns>
        public int RemoveFirst()
        {
            if (Count > 0)
            {
                int result = Head.Value;
                ListNode second = Head.Next;
                if (second == null)
                {
                    Tail = null;
                }
                else
                {
                    second.Previous = null;
                }
                
                Head = second;
                Count--;

                return result;
            }

            throw new IndexOutOfRangeException("List is Empty");
        }
        /// <summary>
        /// Removes the element at the end of the collection
        /// </summary>
        /// <returns></returns>
        public int RemoveLast()
        {
            if (Count > 0)
            {
                int result = Tail.Value;
                ListNode previous = Tail.Previous;

                if (previous == null)
                {
                    Head = null;
                }
                else
                {
                    previous.Next = null;
                }
                
                Tail = previous;
                Count--;

                return result;
            }

            throw new IndexOutOfRangeException("List is Empty");
        }
        /// <summary>
        /// Performs an action on each node of the collection
        /// </summary>
        /// <param name="action">Action to be performed</param>
        public void ForEach(Action<int> action)
        {
            ListNode currentNode = Head;

            while (currentNode != null)
            {
                
                action(currentNode.Value);

                currentNode = currentNode.Next;
            }
        }
        /// <summary>
        /// converts list from IEnumerable to array data type
        /// </summary>
        /// <returns></returns>
        public int[] ToArray()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException("Empty list");
            }
            int[] result = new int[Count];
            int index = 0;

            ListNode currentNode = Head;

            while (currentNode != null)
            {
                result[index] = currentNode.Value;
                currentNode = currentNode.Next;
                index++;
            }

            return result;
        }
    }
}
