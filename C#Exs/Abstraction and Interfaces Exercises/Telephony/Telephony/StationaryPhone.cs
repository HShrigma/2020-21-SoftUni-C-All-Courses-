﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public void Call(string number)
        {
            if (number.All(char.IsDigit))
            {
                 Console.WriteLine($"Dialing... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
           
        }
    }
}
