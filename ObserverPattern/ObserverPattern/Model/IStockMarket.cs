using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Model
{
    internal interface IStockMarket
    {
        void RegisterInvestor(IInvestor investor);
        void RemoveInvestor(IInvestor investor);
        void NotifyInvestors(string companyName, decimal stockPrice);
    }
}
