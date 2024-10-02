using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace GenericBoxOfString
{
    public class Box<T> where T: IComparable
    {
        public T Item;

        public Box()
        {
            Item = default;
        }

        public Box(T item)
            :this()
        {
            this.Item = item;
        }
        /// <summary>
        /// Swaps 2 elements with index1 and index2 in a box list
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        public void SwapIndexes( List<Box<T>> box, int index1, int index2)
        {
            List<Box<T>> boxTemp = box;
            boxTemp[index1] = box[index2];
            box[index2] = box[index1];
            box[index1] = boxTemp[index1];
        }
        /// <summary>
        /// Returns string holding information on element data type and element on a single line
        /// foreach element of list.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.Item.GetType()}: {this.Item}";
        }

        public int GreaterThanCount(T bar, List<Box<T>> toCompare)
        {
            int count = 0;

            foreach (var item in toCompare)
            {
                if (item.GreaterThan(item.Item, bar))
                {
                    count++;
                }
            }

            return count;
        }
        /// <summary>
        /// Compares two items:
        /// Returns: 
        /// examined > comparison ? true
        /// else => false
        /// </summary>
        /// <param name="examined"> set to self</param>
        /// <param name="comparison"></param>
        /// <returns></returns>
        public bool GreaterThan(T examined, T comparison)
        {
            if (examined.CompareTo(comparison) > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Compares a value to another one
        /// Returns:
        /// value > other => 1
        /// value < other => -1
        /// value == other => 0
        /// </summary>
        /// <param name="other"> value to compare to Item</param>
        /// <returns></returns>
        public int CompareTo([AllowNull] T other)
        {
            return Item.CompareTo(other);
        }
    }
}
