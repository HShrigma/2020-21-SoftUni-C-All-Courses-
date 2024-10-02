using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTuple
{
    public class Tuple<T1,T2>
    {
        public T1 Item1;
        public T2 Item2;
        public Tuple()
        {
            Item1 = default;
            Item2 = default;
        }

        public Tuple(T1 item, T2 item1)
            :this()
        {
            this.Item1 = item;
            this.Item2 = item1;
        }
        /// <summary>
        /// Returns Tuple values in the following format:
        /// item1 -> item2
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2}";
        }
    }
}
