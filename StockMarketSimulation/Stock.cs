using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    class Stock
    {
        private string name;
        public string Name
        {
            get{ return name;}
        }

        private List<double> priceHistory;
        public List<double> PriceHistory
        {
            get { return priceHistory; }
        }

        private double currentPrice;
        public double CurrentPrice
        {
            get { return currentPrice; }
        }
        
        public Stock(string name)
        {
            this.name = name;
            this.priceHistory = new List<double>();
            this.currentPrice = 0;
        }

        public double GetPriceFromDay(int day)
        {
            if (priceHistory.Count <= day)
                return this.priceHistory.ElementAt(day);
            else
                return 0; //TODO: Exception
        }

        public List<double> GetPricesSince(int days)
        {
            if (priceHistory.Count >= days)
                return this.priceHistory.GetRange(priceHistory.Count - days, days);
            else
                return null; //TODO: Exception
        }

        public List<double> GetPricesFromTo(int fromDay, int toDay)
        {
            if (priceHistory.Count >= toDay - fromDay)
                return priceHistory.GetRange(fromDay, toDay - fromDay);
            else
                return priceHistory;
        }

        public void AddPrice(double price)
        {
            this.priceHistory.Add(price);
        }

        public void increasePriceHistory(int amount)
        { 
            int addition = amount - priceHistory.Count;
            if (amount > 0)
            {
                for (int i = 0; i < amount; i++)
                {
                    AddPrice(0.0);
                }
            }
        }
    }
}
