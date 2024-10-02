using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_and_Classes_Lab_06_Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] inputToBox = input.Split();

                Item item = new Item
                {
                    ItemName = inputToBox[1],
                    ItemPrice = double.Parse(inputToBox[3])
                };

                Box box = new Box
                {
                    SerialNumber = inputToBox[0],
                    ItemInBox = item,
                    ItemQuantity = int.Parse(inputToBox[2]),
                    BoxPrice = item.ItemPrice * int.Parse(inputToBox[2])
                };

                boxes.Add(box);
            }
            boxes.Sort(
                delegate (Box x, Box y)
            {
                return x.BoxPrice.CompareTo(y.BoxPrice);
            });

            boxes.Reverse();

            foreach (var box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}\n-- {box.ItemInBox.ItemName} - ${ box.ItemInBox.ItemPrice:F2}: { box.ItemQuantity}\n-- ${box.BoxPrice:F2}");
            }
        }
    }

    class Item
    {
        /*{Serial Number} {Item Name} {Item Quantity} {itemPrice}
         */

        public string ItemName { get; set; }

        public double ItemPrice { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }

        public Item ItemInBox { get; set; }

        public int ItemQuantity { get; set; }

        public double BoxPrice { get; set; }
    }
}
