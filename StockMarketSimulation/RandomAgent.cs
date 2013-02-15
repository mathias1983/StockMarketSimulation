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
        public int stopLossInterval;
        public bool actedBeforeOpening;

        public float budget;
        public List<float> budgetHistory;

        public float probOfImitatingTheMarket;
        public float probOfLocalImitation;
        public float asymmetricBuySellProb;
        public float agentProbToActBeforeOpening;
        public float minCorrectingCoefficient;
        public float maxCorrectingCoefficient;
        public float floorP;
        public float agentProbToActBelowFloorPrice;

        public int meanPriceHistoryLength;
        public int localHistoryLength;
        public float agentProbToAdoptStopLoss;
        public float maxLossRate;

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

            while (!isBudgetHighEnough(tempOrder) && tempOrder.OrderAgentSizeOrder > 0)
            {
                tempOrder.OrderAgentSizeOrder--;
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
    }
}
