using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    class RandomAgent : Agent
    {

        public RandomAgent(int number, DefaultValues df)
        {
            this.number = number;
            this.maxOrderNumber = df.maxOrderNumber;

            this.minCorrectingCoefficient = df.minCorrectingCoefficient;
            this.maxCorrectingCoefficient = df.maxCorrectingCoefficient;

            this.budget = df.budget;
            this.budgetHistory = new List<float>();
            this.budgetHistory.Add(this.budget);
            this.ownedStocks = new Dictionary<int, int>();
            createStockInventory(df);

        }
        public override Order act(Stock currentStock)
        {
            Order tempOrder = new Order();

            //1 is buy and -1 is sell
            int buyOrSell = random.NextDouble() < 0.5 ? 1 : -1;
            double LastPrice = currentStock.stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay - 1);
            double price = LastPrice * getRandomDouble(this.minCorrectingCoefficient, this.maxCorrectingCoefficient);

            tempOrder.OrderAgentPriceOfOrder = (float)price * buyOrSell;
            tempOrder.OrderAgentNumber = this.number;
            tempOrder.simulationDay = StockMarketSimulation.simDay;
            tempOrder.OrderAgentSizeOrder = random.Next(1, maxOrderNumber + 1);

            account(ref tempOrder, ref currentStock);
            return tempOrder;
        }

        public override Order actBeforeOpening(Stock currentStock)
        {
            Order tempOrder = new Order();
            //never act before opening, place random order in act()
            tempOrder.OrderAgentPriceOfOrder = 0;
            return tempOrder;
        }


    }
}
