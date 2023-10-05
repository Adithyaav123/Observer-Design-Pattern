using ObserverPattern.Model;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock googleStock = new Stock("Google", 1500.00m);

            Investor investor1 = new Investor("Adithya");
            Investor investor2 = new Investor("Arya");

            googleStock.RegisterInvestor(investor1);
            googleStock.RegisterInvestor(investor2);

            googleStock.UpdateStockPrice(1550.50m);

            googleStock.RemoveInvestor(investor2);

            googleStock.UpdateStockPrice(1565.25m);

            Console.ReadLine();
        }
    }
}