using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Model
{
    internal class Stock:IStockMarket
    {
        private string CompanyName;
        private decimal StockPrice;
        private List<IInvestor> investors = new List<IInvestor>();

        public Stock(string companyName, decimal stockPrice)
        {
            this.CompanyName = companyName;
            this.StockPrice = stockPrice;
        }

        public void RegisterInvestor(IInvestor investor)
        {
            investors.Add(investor);
        }

        public void RemoveInvestor(IInvestor investor)
        {
            investors.Remove(investor);
        }

        public void NotifyInvestors(string companyName, decimal stockPrice)
        {
            foreach (Investor investor in investors)
            {
                investor.Update(companyName, stockPrice);
            }
        }

        public void UpdateStockPrice(decimal newPrice)
        {
            StockPrice= newPrice;
            NotifyInvestors(CompanyName, StockPrice);
        }
    }
}
