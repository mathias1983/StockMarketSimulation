using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public class RiskSeekingAgent : Agent
    {
        public int meanPriceHistoryLength;
        public double maxInvest = 1;
        public double minInvest = 0.1;

        public RiskSeekingAgent(int number, DefaultValues df)
        {
            this.number = number;
            this.maxOrderNumber = df.maxOrderNumber;
            this.minCorrectingCoefficient = df.minCorrectingCoefficient;
            this.maxCorrectingCoefficient = df.maxCorrectingCoefficient;
            this.meanPriceHistoryLength = df.meanPriceHistoryLength;

            this.budget = df.budget;
            this.budgetHistory = new List<float>();
            this.budgetHistory.Add(this.budget);
            this.ownedStocks = new Dictionary<int, int>();
            createStockInventory(df);
        }

        public override Order act(Stock currentStock)
        {
            Order tempOrder = new Order();
            List<double> lastPrices = currentStock.GetPricesSince(this.meanPriceHistoryLength);
            double LastPrice = currentStock.stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay - 1);

            if (lastPrices == null)
            {
                lastPrices = new List<double>();
                lastPrices.Add(1.0);
            }

            int tempHistory = this.meanPriceHistoryLength;

            while (tempHistory > lastPrices.Count)
                tempHistory--;

            if (tempHistory == 0)
                return tempOrder;

            double r = 0;


            // MA
            for (int i = 0; i < tempHistory; i++)
            {
                r += LastPrice - lastPrices.ElementAt(i);
            }


            double tempBudget = 0;

            // risk seeking approach
            if (r <= 0)
            {
                tempOrder.OrderAgentSizeOrder = random.Next(1, Convert.ToInt32(Math.Ceiling((double)(maxOrderNumber + 1) * minInvest)));
                tempBudget = this.budget * minInvest;
            }
            else
            {
                tempOrder.OrderAgentSizeOrder = random.Next(1, Convert.ToInt32((maxOrderNumber + 1) * maxInvest));
                tempBudget = this.budget * maxInvest;
            }
            int choice = 1;
            if (r < 0)
                choice = -1;

            double price = LastPrice * getRandomDouble(this.minCorrectingCoefficient, this.maxCorrectingCoefficient);

            tempOrder.OrderAgentPriceOfOrder = (float)price * choice;
            tempOrder.OrderAgentNumber = this.number;
            tempOrder.simulationDay = StockMarketSimulation.simDay;
            tempOrder.OrderAgentSizeOrder = random.Next(1, maxOrderNumber + 1);

            account(ref tempOrder, ref currentStock, tempBudget);

            return tempOrder;
        }

    }
}
