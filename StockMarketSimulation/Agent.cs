using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public class Agent
    {
        public int number;
        public int maxOrderNumber;

        public float budget;
        public List<float> budgetHistory;
        //stocks that are owned <stocknumber, amount>
        public Dictionary<int, int> ownedStocks;

        public float minCorrectingCoefficient;
        public float maxCorrectingCoefficient;

        // Without static Random always the same result with nextdouble() 

        protected static Random random = new Random();

        public virtual Order act(Stock currentStock) { return new Order(); }
        public virtual Order actBeforeOpening(Stock currentStock) { return new Order(); }

        protected void account(ref Order tempOrder, ref Stock currentStock, double tempBudget)
        {
            //buy
            if (tempOrder.OrderAgentPriceOfOrder > 0)
            {
                while (!isBudgetHighEnough(tempOrder, tempBudget) && tempOrder.OrderAgentSizeOrder > 0)
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
        }

        protected void account(ref Order tempOrder, ref Stock currentStock)
        {
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
        }
        protected bool isBudgetHighEnough(Order currentOrder)
        {
            return this.budget - currentOrder.OrderAgentSizeOrder * currentOrder.OrderAgentPriceOfOrder > 0;
        }

        protected bool isBudgetHighEnough(Order currentOrder, double tempBudget)
        {
            return tempBudget - currentOrder.OrderAgentSizeOrder * currentOrder.OrderAgentPriceOfOrder > 0;
        }

        protected bool ownsEnoughStocks(int stocknumber, int amount)
        {
            if (!ownedStocks.ContainsKey(stocknumber)) return false;

            return ownedStocks[stocknumber] >= amount;
        }

        protected void addToOwnedStocks(Stock stock, int amount)
        {
            this.ownedStocks[Convert.ToInt32(stock.Name)] += amount;
        }

        protected void removeFromOwnedStocks(Stock stock, int amount)
        {
            this.ownedStocks[Convert.ToInt32(stock.Name)] -= amount;
        }

        protected void createStockInventory(DefaultValues defaultValues)
        {
            for (int i = 0; i < defaultValues.stockNumber; i++)
            {
                this.ownedStocks.Add(i, 0);
            }
        }

        public int getDecisionsOfLastAgents(int length, Stock stock)
        {
            return stock.stockPriceBook.getLocalHistory(length);
        }

        protected double getMeanPriceOfDayBefore(Stock stock)
        {
            return stock.stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay - 1);
        }

        protected double getMeanPriceOfTwoDaysBefore(Stock stock)
        {

            return stock.stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay - 2);
        }

        public double getRandomDouble(float min, float max)
        {
            double a = random.NextDouble();
            return min + a * (max - min);
        }

        public double getRandomDouble()
        {
            double a = random.NextDouble();

            return a;
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
