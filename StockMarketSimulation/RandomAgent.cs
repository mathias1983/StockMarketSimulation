using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    class RandomAgent : Agent
    {
        public int number;
        public int maxOrderNumber;

        public float budget;
        public List<float> budgetHistory;
        public Dictionary<int, int> ownedStocks;

        public float minCorrectingCoefficient;
        public float maxCorrectingCoefficient;

        // Without static Random always the same result with nextdouble() 

        private static Random random = new Random();
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
        public Order act(Stock currentStock)
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

            //buy
            if (tempOrder.OrderAgentPriceOfOrder > 0)
            {
                while (!isBudgetHighEnough(tempOrder) && tempOrder.OrderAgentSizeOrder > 0)
                    tempOrder.OrderAgentSizeOrder--;
                addToOwnedStocks(currentStock, tempOrder.OrderAgentSizeOrder);
            }
            //sell
            else if (tempOrder.OrderAgentPriceOfOrder < 0)
            {
                while (!ownsEnoughStocks(Convert.ToInt32(currentStock.Name), tempOrder.OrderAgentSizeOrder) && tempOrder.OrderAgentSizeOrder > 0)
                {
                    tempOrder.OrderAgentSizeOrder--;
                }
                removeFromOwnedStocks(currentStock, tempOrder.OrderAgentSizeOrder);
            }

            this.budget -= tempOrder.OrderAgentSizeOrder * tempOrder.OrderAgentPriceOfOrder;
            this.budgetHistory.Add(this.budget);
            return tempOrder;
        }

        public Order actBeforeOpening(Stock currentStock)
        {
            Order tempOrder = new Order();
            //never act before opening, place random order in act()
            tempOrder.OrderAgentPriceOfOrder = 0;
            return tempOrder;
        }

        private bool isBudgetHighEnough(Order currentOrder)
        {
            return this.budget - currentOrder.OrderAgentSizeOrder * currentOrder.OrderAgentPriceOfOrder > 0;
        }

        private bool ownsEnoughStocks(int stocknumber, int amount)
        {
            if (!ownedStocks.ContainsKey(stocknumber)) return false;

            return ownedStocks[stocknumber] >= amount;
        }

        private void addToOwnedStocks(Stock stock, int amount)
        {
            this.ownedStocks[Convert.ToInt32(stock.Name)] += amount;
        }

        private void removeFromOwnedStocks(Stock stock, int amount)
        {
            this.ownedStocks[Convert.ToInt32(stock.Name)] -= amount;
        }

        private void createStockInventory(DefaultValues defaultValues)
        { 
            for(int i=0; i<defaultValues.stockNumber; i++)
            {
                this.ownedStocks.Add(i, 0);
            }
        }

        private int getDecisionsOfLastAgents(int length, Stock stock)
        {
            return stock.stockPriceBook.getLocalHistory(length);
        }

        private double getRandomDouble(float min, float max)
        {
            double a = random.NextDouble();
            return min + a * (max - min);
        }

        public int getAgentNumber()
        {
            return this.number;
        }

        public List<float> getBudgetHistory()
        {
            return this.budgetHistory;
        }

        public float getBudget()
        {
            return this.budget;
        }

        public Dictionary<int, int> getStockInventory()
        {
            return this.ownedStocks;
        }
    }
}
