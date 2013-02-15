using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public class TernaAgent : Agent
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

        public TernaAgent(int number, DefaultValues df)
        {
            this.number = number;
            this.maxOrderNumber = df.maxOrderNumber;
            this.stopLossInterval = df.stopLossInterval;
            this.probOfImitatingTheMarket = df.probOfImitatingTheMarket;
            this.probOfLocalImitation = df.probOfLocalImitation;
            this.asymmetricBuySellProb = df.asymmetricBuySellProb;
            this.agentProbToActBeforeOpening = df.agentProbToActBeforeOpening;
            this.minCorrectingCoefficient = df.minCorrectingCoefficient;
            this.maxCorrectingCoefficient = df.maxCorrectingCoefficient;
            this.floorP = df.floorP;
            this.agentProbToActBelowFloorPrice = df.agentProbToActBelowFloorPrice;
            this.meanPriceHistoryLength = df.meanPriceHistoryLength;
            this.localHistoryLength = df.localHistoryLength;
            this.agentProbToAdoptStopLoss = df.agentProbToAdoptStopLoss;
            this.maxLossRate = df.maxLossRate;
            this.budget = df.budget;
            this.budgetHistory = new List<float>();
            this.budgetHistory.Add(this.budget);

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

        public Order act(Stock currentStock)
        {

            Order tempOrder = new Order();
            
            //if agent has acted before opening
            //return 0 price order that is ignored in the stockpricebook
            if (actedBeforeOpening)
            {
                tempOrder.OrderAgentPriceOfOrder = 0;
                return tempOrder;
            }


            double LastPrice = currentStock.stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay - 1);

            double buysellswitch = 0.5;

            if (this.probOfImitatingTheMarket > getRandomDouble())
            {
                if (getMeanPriceOfTwoDaysBefore(currentStock) < getMeanPriceOfDayBefore(currentStock))
                {
                    buysellswitch = this.asymmetricBuySellProb;
                }
                if (getMeanPriceOfTwoDaysBefore(currentStock) > getMeanPriceOfDayBefore(currentStock))
                {
                    buysellswitch = 1 - this.asymmetricBuySellProb;
                }
            }


            int choice = 1;

            if (this.probOfLocalImitation > getRandomDouble())
            {
                int tempDecision = getDecisionsOfLastAgents(this.localHistoryLength, currentStock);
                if (tempDecision > 0)
                {
                    buysellswitch = 1 - this.asymmetricBuySellProb;
                }
                if (tempDecision < 0)
                {
                    buysellswitch = this.asymmetricBuySellProb;
                }

            }

            if (buysellswitch < getRandomDouble())
            {
                choice = -1;
            }

            double price = LastPrice * getRandomDouble(this.minCorrectingCoefficient, this.maxCorrectingCoefficient);

            if (LastPrice < this.floorP)
            {
                if (this.agentProbToActBelowFloorPrice > getRandomDouble())
                {
                    price = LastPrice;
                    choice = 1;
                }
            }

            int stopLossChoice = 0;
            double stopLossMeanPrice = currentStock.stockPriceBook.getMeanPrice(this.stopLossInterval);

            if (LastPrice >= stopLossMeanPrice * (1 + this.maxLossRate))
                stopLossChoice = 1;
            if (LastPrice <= stopLossMeanPrice * (1 - this.maxLossRate))
                stopLossChoice = -1;

            if (stopLossChoice != 0)
            {
                if (this.agentProbToAdoptStopLoss > getRandomDouble())
                {
                    price = LastPrice;
                    choice = stopLossChoice;
                }
            }

            tempOrder.OrderAgentPriceOfOrder = (float)price * choice;
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
            actedBeforeOpening = false;

            Order tempOrder = new Order();
            double LastPrice = currentStock.stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay - 1);
            double buysellswitch = 0.5;
            if (this.probOfImitatingTheMarket > getRandomDouble())
            {
                if (getMeanPriceOfTwoDaysBefore(currentStock) < getMeanPriceOfDayBefore(currentStock))
                {
                    buysellswitch = 1 - this.asymmetricBuySellProb;
                }
                if (getMeanPriceOfTwoDaysBefore(currentStock) > getMeanPriceOfDayBefore(currentStock))
                {
                    buysellswitch = this.asymmetricBuySellProb;
                }
            }

            int choice = 1;

            if (this.probOfLocalImitation > getRandomDouble())
            {
                int tempDecision = getDecisionsOfLastAgents(this.localHistoryLength, currentStock);
                if (tempDecision > 0)
                {
                    buysellswitch = this.asymmetricBuySellProb;
                }
                if (tempDecision < 0)
                {
                    buysellswitch = 1 - this.asymmetricBuySellProb;
                }

            }
            //until here it is set
            if (buysellswitch < getRandomDouble())
            {
                choice = -1;
            }

            double price = LastPrice * getRandomDouble(this.minCorrectingCoefficient, this.maxCorrectingCoefficient);

            if (LastPrice < this.floorP)
            {
                if (this.agentProbToActBelowFloorPrice > getRandomDouble())
                {
                    price = LastPrice;
                    choice = 1;
                }
            }

            int stopLossChoice = 0;
            double stopLossMeanPrice = currentStock.stockPriceBook.getMeanPrice(this.stopLossInterval);

            if (LastPrice >= stopLossMeanPrice * (1 + this.maxLossRate))
                stopLossChoice = 1;
            if (LastPrice <= stopLossMeanPrice * (1 - this.maxLossRate))
                stopLossChoice = -1;

            if (stopLossChoice != 0)
            {
                if (this.agentProbToAdoptStopLoss > getRandomDouble())
                {
                    price = LastPrice;
                    choice = stopLossChoice;
                }
            }

            if (price != 0) actedBeforeOpening = true;

            tempOrder.OrderAgentPriceOfOrder = (float)price * choice;
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

        private bool isBudgetHighEnough(Order currentOrder)
        {
            return this.budget - currentOrder.OrderAgentSizeOrder * currentOrder.OrderAgentPriceOfOrder > 0;
        }

        private int getDecisionsOfLastAgents(int length, Stock stock)
        {
            return stock.stockPriceBook.getLocalHistory(length);
        }

        private double getMeanPriceOfDayBefore(Stock stock)
        {
            return stock.stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay - 1);
        }

        private double getMeanPriceOfTwoDaysBefore(Stock stock)
        {

            return stock.stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay - 2);
        }

        private double getRandomDouble()
        {
            double a = random.NextDouble();

            return a;
        }

        private double getRandomDouble(float min, float max)
        {
            double a = random.NextDouble();
            return min + a * (max - min);
        }
    }
}
