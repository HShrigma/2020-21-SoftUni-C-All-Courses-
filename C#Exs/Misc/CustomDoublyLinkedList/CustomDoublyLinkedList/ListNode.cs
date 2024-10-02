using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    /// <summary>
    ///  Node containing an element's value, as well as pointers
    ///  to the previous and next element in a doubly linked list
    /// </summary>
    public class ListNode
    {
        /// <summary>
        /// The value of the Node
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Pointer to the previous node
        /// </summary>
        public ListNode Previous { get; set; }
        /// <summary>
        /// Pointer to the next node
        /// </summary>
        public ListNode Next { get; set; }
        public ListNode()
        {

        }
        public ListNode(int value)
            : this()
        {
            this.Value = value;
        }
    }
}
