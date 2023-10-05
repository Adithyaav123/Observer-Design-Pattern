using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Model
{
    internal class Investor:IInvestor
    {
        private string Name;

        public Investor(string name)
        {
            this.Name = name;
        }

        public void Update(string companyName, decimal stockPrice)
        {
            Console.WriteLine($"{Name} received an update: {companyName} stock price is now ${stockPrice}");
        }
    }
}
