using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList vs = new RandomList() { "Stoyan", "Kolev", "is", "the", "master", "of", "piko"};
            Console.WriteLine(vs.RandomString());
            Console.WriteLine(string.Join(' ', vs));

        }
    }
}
