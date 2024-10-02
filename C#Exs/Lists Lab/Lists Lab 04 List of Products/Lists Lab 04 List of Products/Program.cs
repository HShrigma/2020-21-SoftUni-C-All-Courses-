using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Lab_04_List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int produtsCount = int.Parse(Console.ReadLine());
            
            List<string> productList = new List<string>();

            for (int i = 0; i < produtsCount; i++)
            {
                productList.Add(Console.ReadLine());
            }

            productList.Sort();
            
            int productsTracker = 1;
            
            foreach (var product in productList)
            {
                Console.WriteLine($"{productsTracker}.{product}");
                productsTracker++;
            }
        }
    }
}
