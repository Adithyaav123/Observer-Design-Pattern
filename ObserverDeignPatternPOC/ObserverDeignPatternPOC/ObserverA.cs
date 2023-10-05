using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDeignPatternPOC
{
    internal class ObserverA : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Observer A received message: {message}");
        }
    }
}
