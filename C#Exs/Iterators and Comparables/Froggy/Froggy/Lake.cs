using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public void Create(int[] vs)
        {
            stones = vs.ToList();
        }

        public List<int> Stones { get { return stones; } set { stones = value; } }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return stones[i];
                }
            }

            for (int i = stones.Count - 1 ; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return stones[i];
                }
            }
        }

        public void Print()
        {
            Console.WriteLine(string.Join(", ", this));
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
