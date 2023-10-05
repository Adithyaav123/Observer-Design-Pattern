﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDeignPatternPOC
{
    internal class ObserverB : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Observer B received message: {message}");
        }
    }
}
